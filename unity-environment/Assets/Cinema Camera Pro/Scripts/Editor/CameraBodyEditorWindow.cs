using UnityEngine;
using UnityEditor;
using System.Collections;
using System.Collections.Generic;
using CinemaProCams;

/// <summary>
/// Camera body editor window.
/// 
/// Used to create a new CameraBody object.
/// </summary>
public class CameraBodyEditorWindow : EditorWindow {

    private const string version = "1.4.2.2";

	private GameObject 		_javelinCamera;
	private string 			_cameraName = "Pro Cam";
	private Transform		_rigTransform;
	
	private RenderTexture	_rt = null;
	
	private string[] 		_ffList;
	private string[] 		_resolutionList;
	private string[] 		_lensKitList;
	private string[] 		_lensList;
	private string[] 		_fstopList;

    private UnitOfMeasure   _unitOfMeasure = UnitOfMeasure.Metric;
    private int             _currentFilmFormatIndex = 0;
    private int             _currentScreenSizeIndex = 0;
	private int 			_lensKitIndex = 0;
	private int 			_lensIndex = 0;
	private int 			_fstopIndex = 0;
    
	private float 			_focusDistance = 1f;
	private float 			_lastScale = 1;
	
	private bool			_togglePreview = false;
	
	private Vector2			_scrollPos = new Vector2(0,0);
	
	[MenuItem ("Window/Cinema Suite/Cinema Pro Cams/Create Pro Cam", false, 30)]
    public static void CreateJavelinCamera () {
        EditorWindow.GetWindow (typeof(CameraBodyEditorWindow), false, "Pro Cam");
    }

    void Awake()
    {
        EditorPrefs.SetString("CinemaProCamsVersion", version);
    }

	void OnGUI () {
		UpdateLists ();
		
		_scrollPos = EditorGUILayout.BeginScrollView(_scrollPos); 
		
		EditorGUILayout.BeginVertical("box");
			DrawNameField ();
            DrawUnitOfMeasureField();
			DrawFilmFormatField ();
			DrawScreenSizeField ();
			DrawRigTransformField ();
		EditorGUILayout.EndVertical();
		
		EditorGUILayout.BeginVertical("box");
			DrawLensKitField ();
			DrawLensField ();
		EditorGUILayout.EndVertical();
		
		EditorGUILayout.BeginVertical("box");
			DrawFStopField ();
			DrawFocusDistanceField ();
			DrawDepthOfFieldField ();
		EditorGUILayout.EndVertical();
		
		EditorGUILayout.BeginVertical("box");
			EditorGUILayout.BeginHorizontal();
				if (GetCreateButton()) {
					_javelinCamera = CreateCameraBody ();
					SetupCameraBodyScript (_javelinCamera);
					//CreateCameraBodyPrefab (_javelinCamera);
				}
				
				GetPreviewButton();
			EditorGUILayout.EndHorizontal();
		EditorGUILayout.EndVertical();
		
		_togglePreview = EditorGUILayout.Toggle("Show Preview", _togglePreview);
		
		DrawCameraPreview(_togglePreview);
		
		EditorGUILayout.EndScrollView();
	}
	
	/// <summary>
	/// Updates the lists.
	/// </summary>
	private void UpdateLists () {
		// Film Formats
		if(_ffList == null)
		{
			List<ProCamsLensDataTable.FilmFormatData>.Enumerator filmFormatList = ProCamsLensDataTable.Instance.FilmFormatDataEmumerator;
			_ffList = new string[ProCamsLensDataTable.Instance.NumFilmFormats];
			int i = 0;
			while(filmFormatList.MoveNext())
			{
				ProCamsLensDataTable.FilmFormatData formatData = filmFormatList.Current;
				_ffList[i] = formatData._formatName;
				++i;
			}
		}
		
		if(_fstopList == null)
		{
			_fstopList = new string[FStop.list.Length];
			int num = FStop.list.Length;
			for(int i = 0; i < num; ++i)
			{
				_fstopList[i] = FStop.list[i].name;
			}
		}
		
	}
	
	/// <summary>
	/// Draws the name field.
	/// </summary>
	private void DrawNameField () {
		_cameraName = EditorGUILayout.TextField("Camera Name", _cameraName);
	}

    private void DrawUnitOfMeasureField()
    {
        UnitOfMeasure temp = (UnitOfMeasure) EditorGUILayout.EnumPopup("Unit of Measure", _unitOfMeasure);

        if (temp != _unitOfMeasure)
        {
            if(temp == UnitOfMeasure.Imperial)
            {
                _focusDistance = ProCamsUtility.Convert(_focusDistance, Units.Meter, Units.Foot);
            }
            else
            {
                _focusDistance = ProCamsUtility.Convert(_focusDistance, Units.Foot, Units.Meter);
            }

            _unitOfMeasure = temp;
        }
    }

	/// <summary>
	/// Draws the film format field.
	/// Must only be used in OnGUI()
	/// This field represents the film format to be used.
	/// This will also update the film width and height as well as the aspect ratio.
	/// </summary>
	private void DrawFilmFormatField () {
		int newIndex = EditorGUILayout.Popup("Film Format", _currentFilmFormatIndex, _ffList);
        if (newIndex != _currentFilmFormatIndex)
		{
			// Update film format, and set screen resolution to 0.
			_currentFilmFormatIndex = newIndex;
			_currentScreenSizeIndex = 0;
			
			// Clear resolution list
			_resolutionList = null;
			
			UpdateFOV();
		}
	}
	
	/// <summary>
	/// Draws the definition field.
	/// </summary>
	private void DrawScreenSizeField() {
		if(_resolutionList == null)
		{
			ProCamsLensDataTable.FilmFormatData curFilmFormatData = ProCamsLensDataTable.Instance.GetFilmFormat(_ffList[_currentFilmFormatIndex]);
			if(curFilmFormatData != null)
			{
				int numSizes = curFilmFormatData._screenSizes.Count;
				_resolutionList = new string[numSizes];
				for(int i = 0; i < numSizes; ++i)
				{
					_resolutionList[i] = curFilmFormatData._screenSizes[i].name;
				}
			}
		}
		
		if(_resolutionList != null)
		{
			int newResIndex = EditorGUILayout.Popup("Screen Size (px)", _currentScreenSizeIndex, _resolutionList);
			if(newResIndex != _currentScreenSizeIndex)
			{
				_currentScreenSizeIndex = newResIndex;
				UpdateFOV();
			}
		}
	}
	
	private void UpdateFOV () {
        ProCamsLensDataTable.FilmFormatData curFilmFormat = ProCamsLensDataTable.Instance.GetFilmFormat(_ffList[_currentFilmFormatIndex]);
		if(curFilmFormat != null)
		{
			if(_currentScreenSizeIndex > curFilmFormat._screenSizes.Count)
			{
				_currentScreenSizeIndex = 0;
			}
		
			if(curFilmFormat._aspect != 0)
			{
                ScreenSize ss = curFilmFormat._screenSizes[_currentScreenSizeIndex];
				float scaleFactor = ss.width / curFilmFormat._aspect;
				PlayerSettings.defaultScreenHeight = (int)(scaleFactor + 0.5f);
				PlayerSettings.defaultScreenWidth = (int)(curFilmFormat._aspect * scaleFactor + 0.5f);
			}
		}
	}
	
	private void DrawRigTransformField () {
		_rigTransform = EditorGUILayout.ObjectField(
			"Attach to Rig", _rigTransform, typeof(Transform), true) as Transform;	
	}
	
	/// <summary>
	/// Draws the lens kit field.
	/// This field represents the lens manufacturer.
	/// </summary>
	private void DrawLensKitField () {
		if(_lensKitList == null)
		{
            ProCamsLensDataTable.FilmFormatData curFilmFormat = ProCamsLensDataTable.Instance.GetFilmFormat(_ffList[_currentFilmFormatIndex]);
			if(curFilmFormat != null)
			{
				_lensKitList = new string[curFilmFormat._lensKits.Count];
				int i = 0;
				foreach(ProCamsLensDataTable.LensKitData lensData in curFilmFormat._lensKits)
				{
					_lensKitList[i] = lensData._lensKit.Replace("/","");
					++i;
				}
				_lensKitIndex = 0;
				_lensList = null;
				_lensIndex = 0;
			}
		}
		
		if(_lensKitList != null)
		{
			int newLensIndex = EditorGUILayout.Popup("Lens Kit", _lensKitIndex, _lensKitList);
			if(newLensIndex != _lensKitIndex)
			{
				_lensList = null;
				_lensIndex = 0;
			}
		}
	}
	
	/// <summary>
	/// Draws the lens field.
	/// It will include a popup for the lens length and labels for offset and hfov
	/// </summary>
	private void DrawLensField () {
		List<string> hfovList = new List<string>();
		List<string> offsetList = new List<string>();

        ProCamsLensDataTable.FilmFormatData curFilmFormat = ProCamsLensDataTable.Instance.GetFilmFormat(_ffList[_currentFilmFormatIndex]);
		if(curFilmFormat != null)
		{
			ProCamsLensDataTable.LensKitData lensKit = curFilmFormat.GetLensKitData(_lensKitIndex);
			if(lensKit != null)
			{
				if(_lensList == null)
				{
					_lensList = new string[lensKit._fovDataset.Count];
					int i = 0;
					foreach(ProCamsLensDataTable.FOVData fovData in lensKit._fovDataset)
					{
						_lensList[i] = fovData._focalLength + "mm";
						++i;
					}
				}
				
				foreach(ProCamsLensDataTable.FOVData fovData in lensKit._fovDataset)
				{
					//float hfov = Lens.GetHorizontalFOV(curFilmFormat._aspect, fovData._unityVFOV);
					// Rounding to two decimal places
					//hfov = Mathf.Floor(hfov * 100) / 100f;
					//hfovList.Add ("" + hfov);
					float hfov = Mathf.Floor(fovData._realHFOV * 100) / 100f;
					hfovList.Add (hfov.ToString());
					
					offsetList.Add ("" + fovData._nodalOffset);
				}
			}
		}

		_lensIndex = EditorGUILayout.Popup("Lenses", _lensIndex, _lensList);
		
		//GUILayout.Space(20f);
		
		DrawNodalPointOffsetField(offsetList[_lensIndex]);
		DrawHFOVField(hfovList[_lensIndex]);
		
	}
	
	/// <summary>
	/// Draws the nodal point offset field.
	/// </summary>
	/// <param name='offset'>
	/// Offset.
	/// </param>
	private void DrawNodalPointOffsetField (string offset)
	{
		//EditorGUILayout.LabelField("Nodal Point Offset", offset + " inches");
	}
	
	/// <summary>
	/// Draws the HFOV field.
	/// </summary>
	/// <param name='hfov'>
	/// Hfov.
	/// </param>
	private void DrawHFOVField (string hfov) {
		EditorGUILayout.LabelField("Real Horizontal FOV", 
			"" + hfov + " degrees (film plane)");
	}
	
	/// <summary>
	/// Draws the F stop field.
	/// F-stop controls the amount of focus.
	/// </summary>
	private void DrawFStopField () {
		_fstopIndex = EditorGUILayout.Popup("FStop / Aperture", _fstopIndex, _fstopList);
	}
	
	/// <summary>
	/// Draws the focus distance field.
	/// </summary>
	private void DrawFocusDistanceField () 
    {
        string unit = (_unitOfMeasure == UnitOfMeasure.Metric) ? "(m)" : "(ft)";
        string label = string.Format("Distance to Subject {0}", unit);
        _focusDistance = EditorGUILayout.FloatField(label, _focusDistance);
		
		if (_focusDistance < 0) {
			_focusDistance *= -1;	
		}
		
	}
	
	/// <summary>
	/// Draws the depth of field field.
	/// </summary>
	private void DrawDepthOfFieldField () {
		
		float F, f, H, S, DN, DF, D, TI, NI, FI;
		
		//float focalLength = ProCamsDataTable.list[_lensKitIndex].lenses[_lensIndex].length;
		float focalLength = 0;
        ProCamsLensDataTable.FilmFormatData curFilmFormat = ProCamsLensDataTable.Instance.GetFilmFormat(_ffList[_currentFilmFormatIndex]);
		if(curFilmFormat != null)
		{
			ProCamsLensDataTable.FOVData fovData = curFilmFormat.GetFOVData(_lensKitIndex, _lensIndex);
			if(fovData != null)
			{
				focalLength = fovData._focalLength;
			}
		}
		
		F = ProCamsUtility.Convert(
			focalLength, 
			Units.Millimeter, // from mm
			Units.Inch); // to inches
		
		f = FStop.list[_fstopIndex].fstop;
		H = (F * F) / (f * 0.001f); // 0.001 = Circle of Confusion

        if (_unitOfMeasure == UnitOfMeasure.Imperial)
        {
            S = ProCamsUtility.Convert(_focusDistance, Units.Foot, Units.Inch);
        }
        else
        {
            S = ProCamsUtility.Convert(_focusDistance, Units.Meter, Units.Inch);
        }
		
		DN = (H * S) / ( H + (S - F)); // near depth of field
		DF = (H * S) / ( H - (S - F)); // far depth of field
		D = DF - DN; // depth of field

        if (_unitOfMeasure == UnitOfMeasure.Imperial)
        {
            // rounding to two decimal places
            D = ProCamsUtility.Convert(D, Units.Inch, Units.Foot); // from inches to feet
            D = Mathf.Floor(D * 100) / 100f;

            DN = ProCamsUtility.Convert(DN, Units.Inch, Units.Foot);
            DN = Mathf.Floor(DN * 100) / 100f;

            DF = ProCamsUtility.Convert(DF, Units.Inch, Units.Foot);
            DF = Mathf.Floor(DF * 100) / 100f;

            TI = Mathf.Floor(
                    ProCamsUtility.Convert(
                        D - Mathf.Floor(D),
                        Units.Foot,
                        Units.Inch));

            NI = Mathf.Floor(
                    ProCamsUtility.Convert(
                        DN - Mathf.Floor(DN),
                        Units.Foot,
                        Units.Inch));

            FI = Mathf.Floor(
                    ProCamsUtility.Convert(
                        DF - Mathf.Floor(DF),
                        Units.Foot,
                        Units.Inch));

            D = Mathf.Floor(D);
            DN = Mathf.Floor(DN);
            DF = Mathf.Floor(DF);

            if (D >= 0)
                EditorGUILayout.LabelField("Depth of Field", "" + D + "' " + TI + "\"");
            else
                EditorGUILayout.LabelField("Depth of Field", "INF");

            EditorGUILayout.LabelField("Near Depth", "" + DN + "' " + NI + "\"");

            if (DF >= 0)
                EditorGUILayout.LabelField("Far Depth", "" + DF + "' " + FI + "\"");
            else
                EditorGUILayout.LabelField("Far Depth", "INF");
        }
        else
        {
            float dof = ProCamsUtility.Convert(D, Units.Inch, Units.Meter);
            float dn = ProCamsUtility.Convert(DN, Units.Inch, Units.Meter);
            float df = ProCamsUtility.Convert(DF, Units.Inch, Units.Meter);

            if (D >= 0)
                EditorGUILayout.LabelField("Depth of Field", dof.ToString("0.00") + "m");
            else
                EditorGUILayout.LabelField("Depth of Field", "INF");

            EditorGUILayout.LabelField("Near Depth", dn.ToString("0.00") + "m");

            if (DF >= 0)
                EditorGUILayout.LabelField("Far Depth", df.ToString("0.00") + "m");
            else
                EditorGUILayout.LabelField("Far Depth", "INF");
        }
	}
	
	/// <summary>
	/// Gets the create button.
	/// </summary>
	/// <returns>
	/// bool whether the button was clicked or not
	/// </returns>
	private bool GetCreateButton () {
		return GUILayout.Button ("Create", GUILayout.Width(100f));
	}
	
	/// <summary>
	/// Gets the preview button.
	/// </summary>
	/// <returns>
	/// The preview button.
	/// </returns>
	private bool GetPreviewButton () {
		return GUILayout.Button ("Preview", GUILayout.Width(100f));
	}
	
	/// <summary>
	/// Creates the camera body.
	/// 
	/// Create all the child nodes for the camera body such as film plane, nodal point and focus object.
	/// Once created, it will update the CameraBody script with the inputed data.
	/// </summary>
	private GameObject CreateCameraBody () 
    {
		SceneView sv = SceneView.lastActiveSceneView;

        GameObject go = new GameObject();
        Undo.RegisterCreatedObjectUndo(go, "Created Camera");

        go.AddComponent<CameraBody>();

		//string lensKitName = "";
        ProCamsLensDataTable.FilmFormatData curFilmFormat = ProCamsLensDataTable.Instance.GetFilmFormat(_ffList[_currentFilmFormatIndex]);
		if(curFilmFormat != null)
		{
			ProCamsLensDataTable.LensKitData lensKitData = curFilmFormat.GetLensKitData(_lensKitIndex);
			if(lensKitData != null)
			{
				//lensKitName = lensKitData._lensKit.Replace(",","");
			}
		}
		
		
		Transform jt = go.transform;
		// The Nodal Point transform which holds the Camera and DOF components
		//GameObject nodalPoint = new GameObject(_cameraName);
			
		//nodalPoint.transform.parent = jt;
		//nodalPoint.transform.position = Vector3.zero;

        if (sv != null)
        {
            Transform ct = sv.camera.transform;
            jt.rotation = ct.rotation;
            jt.position = ct.position;
        }
	
		//Camera cbNodalCamera = nodalPoint.AddComponent<Camera>();

        Camera cbNodalCamera = go.GetComponent<Camera>();
        if (cbNodalCamera == null)
        {
            go.AddComponent<Camera>();
            go.AddComponent<CSDOFScatter>();
        }
		cbNodalCamera.nearClipPlane = 0.01f;
		//cbNodalCamera.cullingMask = ~(1<<8);
        
		
		return go;
	}
	
	/// <summary>
	/// Create the camera body script.
	/// </summary>
	/// <param name='go'>
	/// CameraBody GameObject. The root node GameObject.
	/// </param>
	private CameraBody SetupCameraBodyScript (GameObject go) 
    {
		CameraBody cb = go.GetComponent<CameraBody>();

        ProCamsLensDataTable.FilmFormatData curFilmFormat = ProCamsLensDataTable.Instance.GetFilmFormat(_ffList[_currentFilmFormatIndex]);
        cb.FilmFormatName = curFilmFormat._formatName;
		if(curFilmFormat != null)
		{
            cb.ScreenSizeName = ProCamsLensDataTable.Instance.GetScreenSize(curFilmFormat, _resolutionList[_currentScreenSizeIndex]).name;
			ProCamsLensDataTable.LensKitData lensKitData = curFilmFormat.GetLensKitData(_lensKitIndex);
			if(lensKitData != null)
			{
				cb.LensKitName = lensKitData._lensKit;
				cb.IndexOfLensKit = _lensKitIndex;
				cb.LensFOVList = lensKitData._fovDataset.ToArray();
				cb.IndexOfLens = _lensIndex;
			}
		}

        cb.UnitOfMeasure = _unitOfMeasure;

		// Depth of field
		cb.IndexOfFStop = _fstopIndex;
		cb.FocusDistance = _focusDistance;
		
		// Camera Description
		cb.CameraSpecs = ", " + cb.LensKitName;
		cb.CameraSpecs = cb.CameraSpecs.Replace("/","");
		
		// Camera Name
		cb.CameraDescription = _cameraName;
        go.name = cb.CameraDescription;// +cb.CameraSpecs;
		
		// Rig
		cb.RigTransform = _rigTransform;

		return cb;
	}
	
	private void DestroyCameraBody () {
		MonoBehaviour.DestroyImmediate(_javelinCamera);
	}
	
	/// <summary>
	/// Draws the camera preview.
	/// </summary>
	/// <param name='updatePreview'>
	/// Update preview.
	/// </param>
	private void DrawCameraPreview (bool updatePreview) 
    {
		if (updatePreview && UnityEditorInternal.InternalEditorUtility.HasPro()) 
        {
			
			_javelinCamera = CreateCameraBody();
			
			if (_javelinCamera == null) {
				DestroyCameraBody();
				return;
			}
			
			CameraBody cb = SetupCameraBodyScript(_javelinCamera);
			Camera cbNodalCamera = cb.NodalCamera;
			
			cb.CallUpdate();
			
			int dsWidth = PlayerSettings.defaultScreenWidth;
			int dsHeight = PlayerSettings.defaultScreenHeight;
			
			if (_rt == null || (_rt.width != dsWidth || _rt.height != dsHeight))
				_rt = new RenderTexture(
					dsWidth, dsHeight, (int)RenderTextureFormat.ARGB32 );
			
			CameraClearFlags ccf = cbNodalCamera.clearFlags;
			cbNodalCamera.targetTexture = _rt;
			cbNodalCamera.clearFlags = CameraClearFlags.Skybox;
			cbNodalCamera.Render();
			cbNodalCamera.clearFlags = ccf;
			cbNodalCamera.targetTexture = null;
			
			EditorGUILayout.BeginHorizontal();
				GUILayout.FlexibleSpace();
			EditorGUILayout.EndHorizontal();
			Rect scale = GUILayoutUtility.GetLastRect();
			//EditorGUIUtility.LookLikeInspector();
			//EditorGUIUtility.LookLikeControls(scale.width/2);
			
			// Every other draw will detect the width as 1
			// This will reset scale.width to the previous value that was not 1
			if (scale.width == 1 && _lastScale != 1) scale.width = _lastScale;	
			if (scale.width != 1) _lastScale = scale.width;
			
			// Padding around the window
			float max_width = scale.width - 30f;
			float scale_factor = max_width / dsWidth;
			
			EditorGUILayout.BeginHorizontal();
				GUILayout.Height(100);
				int width = (int)(dsWidth * scale_factor);
				int height = (int)(dsHeight * scale_factor);
				Rect rect = new Rect(scale.x + 15f, scale.y + 10f, width, height);
				GUI.DrawTexture(rect, _rt, ScaleMode.ScaleAndCrop, false);
			EditorGUILayout.EndHorizontal();
			GUILayout.Space(height + 19f);
			
				
				
			DestroyCameraBody ();
		} else return;
		
	}
	
	/// <summary>
	/// Creates the camera body prefab.
	/// 
	/// This will also check for duplicate prefabs. If another prefab with the same name exists,
	/// A new prefab with an appended number will be created.
	/// </summary>
	/// <param name='go'>
	/// GameObject representing the camera body root node.
	/// </param>
	private void CreateCameraBodyPrefab (GameObject go) {
		string 	prefabNumber = "";
		int 	prefabCount = 0;
		
		// loop through all prefabs and break once the name does not exist
		while (true) { 
			Object obj = Resources.Load("CameraBody/" + go.name+prefabNumber);
			
			if (obj == null) {
				
				
				if (!System.IO.Directory.Exists(
					Application.dataPath + "/Resources")) {
					
					AssetDatabase.CreateFolder("Assets","Resources");
				}
				
				if (!System.IO.Directory.Exists(
					Application.dataPath + "/Resources/CameraBody")) {
					
					AssetDatabase.CreateFolder("Assets/Resources","CameraBody");
				}
				
				
				go.name = go.name + prefabNumber;
				PrefabUtility.CreatePrefab(
					"Assets/Resources/CameraBody/" + 
					go.name+".prefab",
					go,
					ReplacePrefabOptions.ConnectToPrefab);
				break;
			}
			
			obj = null;
			prefabNumber = " (" + ++prefabCount + ")";
		}
	}
}