using UnityEngine;
using UnityEditor;
using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

[CustomEditor (typeof(CameraBody))]
[CanEditMultipleObjects]
public class CameraBodyEditor : Editor {
	
	CameraBody 			cb;

	SerializedProperty	_rigTransform;
	SerializedProperty 	_description;
	
	SerializedProperty 	_lensKitName;
	SerializedProperty 	_lensKitIndex;
	
	SerializedProperty 	_lensIndex;
	SerializedProperty 	_fstopIndex;
	SerializedProperty 	_focusDistance;
	SerializedProperty 	_dofDistTotal;
	SerializedProperty 	_dofNearLimit;
	SerializedProperty 	_dofFarLimit;
	SerializedProperty	_focusTransform;
	SerializedProperty	_clickToFocus;
	SerializedProperty	_centerOnSubject;
	SerializedProperty	_showGizmos;
	
	SerializedProperty 	_fpOffset;

    SerializedProperty _unitOfMeasure;
    SerializedProperty _filmFormatName;
    SerializedProperty _screenSizeName;

	string[]			_ffList;
	string[]			_resolutionList;
	string[]			_lensOptions;
	string[]			_fstopOptions;
	
	float				lastScale = 1;
    private int _currentFilmFormatIndex = 0;
    private int _currentScreenSizeIndex = 0;

	bool				togglePreview = true;
	
	void OnEnable () {
        _unitOfMeasure = serializedObject.FindProperty("_unitOfMeasure");
		_rigTransform = 		serializedObject.FindProperty("_rigTransform");
		_description = 			serializedObject.FindProperty("_cameraDesc");
		_lensKitName = 			serializedObject.FindProperty("_lensKitName");
		_lensKitIndex = 		serializedObject.FindProperty("_lensKitIndex");
		_lensIndex =			serializedObject.FindProperty("_lensIndex");
		_fstopIndex = 			serializedObject.FindProperty("_fstopIndex");
		_focusDistance = 		serializedObject.FindProperty("_focusDist");
		_dofDistTotal = 		serializedObject.FindProperty("_dofDistTotal");
		_dofNearLimit = 		serializedObject.FindProperty("_dofNearLimit");
		_dofFarLimit = 			serializedObject.FindProperty("_dofFarLimit");
		_focusTransform = 		serializedObject.FindProperty("_focusTransform");
		_clickToFocus = 		serializedObject.FindProperty("_clickToFocus");
		_centerOnSubject =	 	serializedObject.FindProperty("_centerOnSubject");
		_fpOffset = 			serializedObject.FindProperty("_fpOffset");
		_showGizmos = 			serializedObject.FindProperty("_showGizmos");
        _filmFormatName =       serializedObject.FindProperty("_filmFormatName");
        _screenSizeName =       serializedObject.FindProperty("_screenSizeName");

		cb = target as CameraBody;
		// Populate film formats
		List<ProCamsLensDataTable.FilmFormatData>.Enumerator filmFormatList = ProCamsLensDataTable.Instance.FilmFormatDataEmumerator;
		_ffList = new string[ProCamsLensDataTable.Instance.NumFilmFormats];
		int i = 0;
		while(filmFormatList.MoveNext())
		{
			ProCamsLensDataTable.FilmFormatData formatData = filmFormatList.Current;
			_ffList[i] = formatData._formatName;
            if (_filmFormatName.stringValue == formatData._formatName)
            {
                _currentFilmFormatIndex = i;
            }
			++i;
		}
		
		PopulateLens();
		
		// Populate FStop options
		_fstopOptions = new string[FStop.list.Length];
		int num = FStop.list.Length;
		for(i = 0; i < num; ++i)
		{
			_fstopOptions[i] = FStop.list[i].name;
		}
		
		if (UnityEditorInternal.InternalEditorUtility.HasPro()) {
		
		CameraBody.CameraPreview = 
			new RenderTexture(
				PlayerSettings.defaultScreenWidth, 
	            PlayerSettings.defaultScreenHeight, 
	            (int)RenderTextureFormat.ARGB32 );
		}
	}
	
	// Populate lens data
	void PopulateLens()
	{
        ProCamsLensDataTable.FilmFormatData curFilmFormat = ProCamsLensDataTable.Instance.GetFilmFormat(_filmFormatName.stringValue);
		if(curFilmFormat != null)
		{
			if(_lensKitIndex.intValue < 0 || _lensKitIndex.intValue > curFilmFormat._lensKits.Count)
			{
				_lensKitIndex.intValue = 0;
			}
			
			ProCamsLensDataTable.LensKitData lensKitData = curFilmFormat.GetLensKitData(_lensKitIndex.intValue);
			if(lensKitData != null)
			{
				// Set available lens data for this film format
				cb.LensFOVList = lensKitData._fovDataset.ToArray();
				
				if(_lensIndex.intValue < 0 || _lensIndex.intValue > cb.LensFOVList.Length)
				{
					_lensIndex.intValue = 0;
				}
			}
			
			// Populate lens names
			int numLenses = lensKitData._fovDataset.Count;
			_lensOptions = new string[numLenses];
			for(int i = 0; i < numLenses; ++i)
			{
				_lensOptions[i] = lensKitData._fovDataset[i]._focalLength + "mm";
			}
		}
	}
	
	[ExecuteInEditMode]
	void OnSceneGUI () {
		if (_clickToFocus.boolValue) {
			if (Selection.activeGameObject != null && 
				Selection.activeGameObject != cb.gameObject) {
				cb.FocusTransform = Selection.activeGameObject.transform;
				
				if (_centerOnSubject.boolValue)
					cb.transform.LookAt(Selection.activeGameObject.transform);
			}
			Selection.activeGameObject = cb.gameObject;
		}
		
		Camera c = SceneView.lastActiveSceneView.camera;
		cb.ShowBody = Vector3.Distance(c.transform.position, cb.transform.position) > 0.2f;
	}
	
	/// <summary>
	/// Raises the inspector GUI event.
	/// </summary>
	public override void OnInspectorGUI () {
		serializedObject.Update();
		
		EditorGUILayout.BeginVertical("box");
			EditorGUILayout.LabelField("", "GENERAL", EditorStyles.boldLabel);
			DrawDescriptionField ();
            DrawUnitOfMeasureField();
			DrawFilmFormatField ();
			DrawResolutionField ();
			DrawRigTransformField ();
		EditorGUILayout.EndVertical();
		
		EditorGUILayout.BeginVertical("box");
			EditorGUILayout.LabelField("", "LENS KIT", EditorStyles.boldLabel);
			DrawLensKitField ();
			DrawAspectRatioField ();
		EditorGUILayout.EndVertical();
		
		EditorGUILayout.BeginVertical("box");
			EditorGUILayout.LabelField("", "LENS", EditorStyles.boldLabel);
			DrawLensField ();
			DrawHFOVField ();
			//DrawNodalPointOffsetField ();
			DrawFilmPlaneOffsetField ();
		EditorGUILayout.EndVertical();
		
		EditorGUILayout.BeginVertical("box");
			EditorGUILayout.LabelField("", "DEPTH OF FIELD", EditorStyles.boldLabel);
			DrawFStopField ();
			DrawFocusDistanceField ();
			DrawDepthOfFieldField ();
			DrawFocusTransformField ();
			DrawFocusToggleField ();
			DrawGizmoToggleField ();
		EditorGUILayout.EndVertical();

        EditorGUILayout.BeginVertical("box");
        EditorGUILayout.LabelField("", "ENHANCEMENTS", EditorStyles.boldLabel);
            DrawAddScriptsField();
        EditorGUILayout.EndVertical();

		EditorGUILayout.BeginVertical("box");
			UpdateRenderTexture ();
			DrawCameraPreview ();
		EditorGUILayout.EndVertical();
		
		serializedObject.ApplyModifiedProperties();
		if (GUI.changed) {
			EditorUtility.SetDirty(target);	
		}
	}
	
	private void DrawDescriptionField () {
		string description = _description.stringValue;
		_description.stringValue = 
			EditorGUILayout.TextField("Camera Name", _description.stringValue);
		
		if (description != _description.stringValue)
			UpdateDescription();	
	}

    private void DrawUnitOfMeasureField()
    {
        UnitOfMeasure temp = (UnitOfMeasure)EditorGUILayout.EnumPopup("Unit of Measure", (UnitOfMeasure)_unitOfMeasure.enumValueIndex);

        if (temp != (UnitOfMeasure)_unitOfMeasure.enumValueIndex)
        {
            if (temp == UnitOfMeasure.Imperial)
            {
                _focusDistance.floatValue = ProCamsUtility.Convert(_focusDistance.floatValue, Units.Meter, Units.Foot);
            }
            else
            {
                _focusDistance.floatValue = ProCamsUtility.Convert(_focusDistance.floatValue, Units.Foot, Units.Meter);
            }

            _unitOfMeasure.enumValueIndex = (int)temp;
        }
    }
	
	private void DrawFilmFormatField () {

        int newIndex = EditorGUILayout.Popup("Film Format", _currentFilmFormatIndex, _ffList);
        if (newIndex != _currentFilmFormatIndex)
		{
			_currentFilmFormatIndex = newIndex;
            //Undo.RecordObject(serializedObject.targetObject, "Edit Film Format");
            _filmFormatName.stringValue = _ffList[newIndex];
            _currentScreenSizeIndex = 0;
			_resolutionList = null;
			
			PopulateLens();
		}
	}

	private void DrawResolutionField () {
		if(_resolutionList == null)
		{
			ProCamsLensDataTable.FilmFormatData curFilmFormatData = ProCamsLensDataTable.Instance.GetFilmFormat(_filmFormatName.stringValue);
			if(curFilmFormatData != null)
			{
				int numSizes = curFilmFormatData._screenSizes.Count;
				_resolutionList = new string[numSizes];
				for(int i = 0; i < numSizes; ++i)
				{
					_resolutionList[i] = curFilmFormatData._screenSizes[i].name;
                    if (_resolutionList[i] == _screenSizeName.stringValue)
                    {
                        _currentScreenSizeIndex = i;
                    }
				}
			}
		}
		
		if(_resolutionList != null)
		{
			int newResIndex = EditorGUILayout.Popup("Screen Size (px)", _currentScreenSizeIndex, _resolutionList);
			if(newResIndex != _currentScreenSizeIndex)
			{
				_currentScreenSizeIndex = newResIndex;
                _screenSizeName.stringValue = _resolutionList[_currentScreenSizeIndex];
			}
		}
	}
	
	private void DrawRigTransformField () {
		_rigTransform.objectReferenceValue =
			EditorGUILayout.ObjectField(
				"Attach to Rig", _rigTransform.objectReferenceValue, typeof(Transform), true);
	}
	
	private void DrawLensKitField () {
		EditorGUILayout.LabelField("Lens Kit", _lensKitName.stringValue);
	}
	
	private void DrawAspectRatioField () {
        ProCamsLensDataTable.FilmFormatData curFilmFormatData = ProCamsLensDataTable.Instance.GetFilmFormat(_filmFormatName.stringValue);
		if(curFilmFormatData != null)
		{
			EditorGUILayout.LabelField("Aspect Ratio: ", curFilmFormatData._aspect.ToString());
		}
	}
	
	private void DrawLensField () {
		_lensIndex.intValue = 
			EditorGUILayout.Popup(
				"Focal Length", 
				_lensIndex.intValue, 
				_lensOptions
			);
		UpdateFOV ();
	}
	
	private void DrawHFOVField () {
		//float unityHFOV = 0;
		float realHFOV = 0;

        ProCamsLensDataTable.FilmFormatData curFilmFormatData = ProCamsLensDataTable.Instance.GetFilmFormat(_filmFormatName.stringValue);
		if(curFilmFormatData != null)
		{
			//float ar = curFilmFormatData._aspect;
			//unityHFOV = Mathf.Floor(Lens.GetHorizontalFOV(ar, cb.LensFOVList[cb.IndexOfLens]._unityVFOV) * 100) / 100;
			
			realHFOV = Mathf.Floor(cb.LensFOVList[cb.IndexOfLens]._realHFOV * 100) / 100f;
		}
		
		EditorGUILayout.LabelField("Real Horizontal FOV", "" + realHFOV + " degrees (film plane)");
		//EditorGUILayout.LabelField("Unity Horizontal FOV", "" + unityHFOV + " degrees (nodal pt)");
	}
	
	private void DrawNodalPointOffsetField () {
		EditorGUILayout.LabelField("Nodal Point Offset", "" + cb.LensFOVList[cb.IndexOfLens]._nodalOffset + " inches");	
	}
	
	private void DrawFilmPlaneOffsetField () {
		_fpOffset.vector3Value = EditorGUILayout.Vector3Field("Film Plane Offset (inches)", _fpOffset.vector3Value);
	}
	
	private void DrawFStopField () {
		_fstopIndex.intValue = EditorGUILayout.Popup("FStop / Aperture", _fstopIndex.intValue, _fstopOptions);
	}
	
	private void DrawFocusDistanceField () 
    {
        string unit = ((UnitOfMeasure)_unitOfMeasure.enumValueIndex == UnitOfMeasure.Metric) ? "(m)" : "(ft)";
        string label = string.Format("Distance to Subject {0}", unit);

        _focusDistance.floatValue = EditorGUILayout.FloatField(label, _focusDistance.floatValue);
		
		if (_focusDistance.floatValue < 0) _focusDistance.floatValue *= -1;			
	}
	
	private void DrawDepthOfFieldField () {
		
		float dofTotal, dofNear, dofFar;
		
		dofTotal = _dofDistTotal.floatValue;
		dofNear = _dofNearLimit.floatValue;
		dofFar = _dofFarLimit.floatValue;

        if (((UnitOfMeasure)_unitOfMeasure.enumValueIndex == UnitOfMeasure.Imperial))
        {
            float totalR, nearT, farT;

            totalR = Mathf.Floor((dofTotal - Mathf.Floor(dofTotal)) * 12);
            dofTotal = Mathf.Floor(dofTotal);

            nearT = Mathf.Floor((dofNear - Mathf.Floor(dofNear)) * 12);
            dofNear = Mathf.Floor(dofNear);

            farT = Mathf.Floor((dofFar - Mathf.Floor(dofFar)) * 12);
            dofFar = Mathf.Floor(dofFar);

            string dof = dofTotal >= 0 ? "" + dofTotal + "' " + totalR + "\"" : "INF";
            EditorGUILayout.LabelField("Depth of Field", dof);

            EditorGUILayout.LabelField("Near Limit", "" + dofNear + "' " + nearT + "\"");

            string farLimit = dofFar >= 0 ? "" + dofFar + "' " + farT + "\"" : "INF";
            EditorGUILayout.LabelField("Far Limit", farLimit);
        }
        else
        {
            float dof = ProCamsUtility.Convert(dofTotal, Units.Foot, Units.Meter);
            float dn = ProCamsUtility.Convert(dofNear, Units.Foot, Units.Meter);
            float df = ProCamsUtility.Convert(dofFar, Units.Foot, Units.Meter);

            string dofString = dofTotal >= 0 ? dof.ToString("0.00") +"m": "INF";
            EditorGUILayout.LabelField("Depth of Field", dofString);

            EditorGUILayout.LabelField("Near Limit", dn.ToString("0.00") + "m");

            string farLimit = dofFar >= 0 ? df.ToString("0.00") + "m" : "INF";
            EditorGUILayout.LabelField("Far Limit", farLimit);
        }
	}
	
	private void DrawFocusTransformField () {
		_focusTransform.objectReferenceValue = 
			EditorGUILayout.ObjectField(
				"Drag & Drop to Focus", 
				_focusTransform.objectReferenceValue, 
				typeof(Transform), 
				true);

        if (_focusTransform.objectReferenceValue != null)
        {
            Transform t = _focusTransform.objectReferenceValue as Transform;

            float distanceValue = Vector3.Distance(cb.NodalCamera.transform.position, t.position);
            if (((UnitOfMeasure)_unitOfMeasure.enumValueIndex == UnitOfMeasure.Imperial))
            {
                distanceValue = ProCamsUtility.Convert(distanceValue, Units.Meter, Units.Foot);
            }

            _focusDistance.floatValue = distanceValue;
            _focusTransform.objectReferenceValue = null;
        }
	}
	private void DrawFocusToggleField () {
		EditorGUILayout.BeginHorizontal ();
			_clickToFocus.boolValue = EditorGUILayout.Toggle(
				"Click Subject to Focus", 
				_clickToFocus.boolValue);
		
			_centerOnSubject.boolValue = 
				_clickToFocus.boolValue ? 
					EditorGUILayout.Toggle("Center on Subject", _centerOnSubject.boolValue) : 
					false;
		EditorGUILayout.EndHorizontal ();
	}

    private void DrawAddScriptsField()
    {
        EditorGUILayout.BeginHorizontal();
            EditorGUILayout.Popup(new GUIContent("Add Enhancement"), 0, new GUIContent[]{ new GUIContent("Shake Cam") });
        EditorGUILayout.EndHorizontal();
        EditorGUILayout.BeginHorizontal();
        EditorGUILayout.PrefixLabel(" ");
        if (GUILayout.Button("Add", EditorStyles.miniButtonRight))
        {
            cb.gameObject.AddComponent<ShakeCam>();
        }
        EditorGUILayout.EndHorizontal();
    }

	private void DrawGizmoToggleField () {	
		_showGizmos.boolValue = EditorGUILayout.Toggle("Show Depth of Field", _showGizmos.boolValue);
	}
	
	private void DrawCameraPreview () {
		
		togglePreview = EditorGUILayout.Toggle("Toggle Preview", togglePreview);
		
		if (!togglePreview)
			return;
		
		UpdateRenderTexture ();
		
		if (CameraBody.CameraPreview != null) {
			EditorGUILayout.LabelField("", "CAMERA PREVIEW", EditorStyles.boldLabel);
			
			// hack to get the inspector windows width, height, x and y
			EditorGUILayout.BeginHorizontal();
			GUILayout.FlexibleSpace();
			EditorGUILayout.EndHorizontal();
			Rect scale = GUILayoutUtility.GetLastRect();
			//EditorGUIUtility.LookLikeInspector();
			//EditorGUIUtility.LookLikeControls(scale.width/2);
			
			// Every other frame detects the inspector width as 1, which is wrong
			// This will set the inspector width to the previous value that was not 1
			if (scale.width == 1 && lastScale != 1)	scale.width = lastScale;	
			
			// Update the lastScale so the next frame can get the correct value
			if (scale.width != 1) lastScale = scale.width;	
			
			// Padding around the window
			float max_width = scale.width - 30f;
			float scale_factor = max_width / PlayerSettings.defaultScreenWidth;
			
			int width = (int)(PlayerSettings.defaultScreenWidth * scale_factor);
			int height = (int)(PlayerSettings.defaultScreenHeight * scale_factor);
			
			GUI.DrawTexture( 
				new Rect(
					scale.x + 15f, 
					scale.y + 10f, 
					width, 
					height), 
				CameraBody.CameraPreview, 
				ScaleMode.ScaleAndCrop, 
				false ); 
			
			GUILayout.Space(height + 19f);
			
		}
		
	}
	
	private void UpdateDescription () {
		string newName = _description.stringValue + cb.CameraSpecs;
		
		if (cb.gameObject.name != newName) {
            Undo.RecordObjects(new GameObject[2] { cb.gameObject, cb.NodalCamera.gameObject }, "Rename");
			cb.gameObject.name = newName;
			cb.NodalCamera.name = newName;
		}
	}
	
	private void UpdateRenderTexture () {
		if (UnityEditorInternal.InternalEditorUtility.HasPro()) {
			if (CameraBody.CameraPreview == null) {
				CameraBody.CameraPreview = new RenderTexture(PlayerSettings.defaultScreenWidth, 
		                        PlayerSettings.defaultScreenHeight, 
		                        (int)RenderTextureFormat.ARGB32 );
				return;
			}
			
			if(cb.NodalCamera != null) {
				CameraClearFlags ccf = cb.NodalCamera.clearFlags;
	            cb.NodalCamera.targetTexture = CameraBody.CameraPreview;
				cb.NodalCamera.clearFlags = CameraClearFlags.Color;
	            cb.NodalCamera.Render();
				cb.NodalCamera.clearFlags = ccf;
	            cb.NodalCamera.targetTexture = null;    
	        }
			
		    if(CameraBody.CameraPreview.width != PlayerSettings.defaultScreenWidth || 
		           CameraBody.CameraPreview.height != PlayerSettings.defaultScreenHeight)
			{
				CameraBody.CameraPreview = new RenderTexture(PlayerSettings.defaultScreenWidth, 
				            PlayerSettings.defaultScreenHeight,
				                (int)RenderTextureFormat.ARGB32 );
				cb.NodalCamera.targetTexture = CameraBody.CameraPreview; 
	            cb.NodalCamera.Render();
	            cb.NodalCamera.targetTexture = null;   
			}
		}
	}

	[DrawGizmo(GizmoType.Selected)]
	static void DrawFieldOfViewMarkers(Transform transform, GizmoType gizmoType)
	{   
		CameraBody cb = transform.GetComponent<CameraBody>();

        ProCamsLensDataTable.FilmFormatData curFilmFormat = null;
        if (cb != null)
        {
            curFilmFormat = ProCamsLensDataTable.Instance.GetFilmFormat(cb.FilmFormatName);
        }
		
		if (curFilmFormat != null && cb != null && cb.ShowGizmos && cb.LensFOVList[cb.IndexOfLens] != null) {
			float aspect = curFilmFormat._aspect;
			
			GUIStyle style = new GUIStyle();
			style.normal.textColor = new Color(0,60,160,255);
			
			float nearInches = Mathf.Floor((cb.DOFNearLimit - Mathf.Floor(cb.DOFNearLimit)) * 12);
			float nearFeet = Mathf.Floor(cb.DOFNearLimit);
			
			Transform ct = cb.NodalCamera.transform;
			
			Matrix4x4 oldMatrix = Handles.matrix;
			Handles.matrix = Matrix4x4.TRS(ct.position, ct.rotation, ct.lossyScale);

            if (cb.UnitOfMeasure == UnitOfMeasure.Imperial)
            {
                Vector3 dofNearPos = Vector3.forward * cb.DOFNearLimit * 0.3048f + Vector3.left *
                    ((cb.DOFNearLimit * aspect) / cb.LensFOVList[cb.IndexOfLens]._focalLength);

                Vector3 dofFarPos = Vector3.forward * cb.DOFFarLimit * 0.3048f + Vector3.left *
                        ((cb.DOFFarLimit * aspect) / cb.LensFOVList[cb.IndexOfLens]._focalLength);
                Vector3 dofFocusPos = Vector3.forward * cb.FocusDistance * 0.3048f;
                Handles.Label(dofNearPos, "" + nearFeet + "' " + nearInches + "\"", style);

                float farInches = Mathf.Floor((cb.DOFFarLimit - Mathf.Floor(cb.DOFFarLimit)) * 12);
                float farFeet = Mathf.Floor(cb.DOFFarLimit);

                if (cb.DOFFarLimit >= 0)
                    Handles.Label(dofFarPos, "" + farFeet + "' " + farInches + "\"", style);

                style.normal.textColor = Color.yellow;
                float dofInches = Mathf.Floor((cb.FocusDistance - Mathf.Floor(cb.FocusDistance)) * 12);
                float dofFeet = Mathf.Floor(cb.FocusDistance);
                Handles.Label(dofFocusPos, "" + dofFeet + "' " + dofInches + "\"", style);
            }
            else
            {
                Vector3 dofNearPos = Vector3.forward * cb.DOFNearLimit * 0.3048f + Vector3.left *
                    ((cb.DOFNearLimit * aspect) / cb.LensFOVList[cb.IndexOfLens]._focalLength);

                Vector3 dofFarPos = Vector3.forward * cb.DOFFarLimit * 0.3048f + Vector3.left *
                        ((cb.DOFFarLimit * aspect) / cb.LensFOVList[cb.IndexOfLens]._focalLength);
                Vector3 dofFocusPos = Vector3.forward * cb.FocusDistance;


                Handles.Label(dofNearPos, (cb.DOFNearLimit * 0.3048f).ToString("0.00") + "m", style);

                //float farInches = Mathf.Floor((cb.DOFFarLimit - Mathf.Floor(cb.DOFFarLimit)) * 12);
                //float farFeet = Mathf.Floor(cb.DOFFarLimit);

                if (cb.DOFFarLimit >= 0)
                {
                    Handles.Label(dofFarPos, (cb.DOFFarLimit * 0.3048f).ToString("0.00") + "m", style);
                }

                style.normal.textColor = Color.yellow;
                Handles.Label(dofFocusPos, cb.FocusDistance.ToString("0.00") + "m", style);

            }

			Handles.matrix = oldMatrix;
		}
	}
	
	private void UpdateFOV () {
		ProCamsLensDataTable.FilmFormatData curFilmFormat = ProCamsLensDataTable.Instance.GetFilmFormat(_filmFormatName.stringValue);
		if(curFilmFormat != null)
		{
			if(_currentScreenSizeIndex > curFilmFormat._screenSizes.Count)
			{
				_currentScreenSizeIndex = 0;
			}
		
			if(curFilmFormat._aspect != 0)
			{
                ScreenSize ss = ProCamsLensDataTable.Instance.GetScreenSize(curFilmFormat, _resolutionList[_currentScreenSizeIndex]);
                float scaleFactor = ss.width / curFilmFormat._aspect;
				PlayerSettings.defaultScreenHeight = (int)(scaleFactor + 0.5f);
				PlayerSettings.defaultScreenWidth = (int)(curFilmFormat._aspect * scaleFactor + 0.5f);
			}
		}
	}
}