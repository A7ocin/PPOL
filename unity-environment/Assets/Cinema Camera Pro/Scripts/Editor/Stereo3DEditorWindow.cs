using UnityEngine;
using UnityEditor;
using System.Collections;

public class Stereo3DEditorWindow : EditorWindow {
	
	int							_selectedRig;
	public static string[]		_rigList;
	CameraBody					_cb;
	
	float						_interaxial;
	float						_convergence;
	float						_minInteraxial;
	float						_maxInteraxial;
	
	float						_minConvergence;
	float						_maxConvergence;
	
	StereoState					_sstate;

    string sname = "3D Pro Cam";
	[MenuItem ("Window/Cinema Suite/Cinema Pro Cams/Create 3D Pro Cam", false, 30)]
    public static void CreateJavelinCamera () {
        Stereo3DEditorWindow w = (Stereo3DEditorWindow)EditorWindow.GetWindow (typeof(Stereo3DEditorWindow), false, "3D Pro Cam");
		w.minSize = new Vector2(200, 300);
	
    }
	
	static Stereo3DEditorWindow () {
		_rigList = new string[]{
			"Tango",
			"TS5",
			"TS2"
		};	
	}
	
	void OnGUI () {

        EditorGUILayout.BeginVertical("box");
        sname = EditorGUILayout.TextField("Camera Name", sname);
        DrawCBField();
        DrawRigField();
        EditorGUILayout.EndVertical();

        EditorGUILayout.BeginVertical("box");
        
        //DrawMinInteraxialField();
        //DrawMaxInteraxialField();

        //DrawMinConvergenceField();
        //DrawMaxConvergenceField();
        DrawConvergenceField();
		DrawInteraxialField();
		Draw3DModeField();
        EditorGUILayout.EndVertical();

        EditorGUILayout.BeginVertical("box");
		if (DrawCreateButton()) {
			Create();
		}
        EditorGUILayout.EndVertical();
	}
	
	void DrawRigField () {
		_selectedRig = EditorGUILayout.Popup("Rig", _selectedRig, _rigList);
		
		switch (_selectedRig) {
		case 0: {	
			_minInteraxial = 0;
			_maxInteraxial = 0.07f;
			_minConvergence = -5;
			_maxConvergence = 3;
		}
			break;
		case 1: {
			_minInteraxial = 0;
			_maxInteraxial = .1f;
			_minConvergence = -1;
			_maxConvergence = 3;
		}
			break;
		case 2: {
			_minInteraxial = 0;
			_maxInteraxial = .15f;
			_minConvergence = -1;
			_maxConvergence = 3;
		} break;
			
		}
	}
	
	void DrawCBField () {
		_cb = (CameraBody)EditorGUILayout.ObjectField("Camera Body", _cb, typeof(CameraBody),true);	
	}
	
	void DrawMinInteraxialField () {
		_minInteraxial = EditorGUILayout.FloatField("Min Interaxial", _minInteraxial);
	}
	
	void DrawMaxInteraxialField () {
		_maxInteraxial = EditorGUILayout.FloatField("Max Interaxial", _maxInteraxial);
	}
	
	void DrawInteraxialField () {
		_interaxial = EditorGUILayout.Slider("Interaxial", _interaxial, _minInteraxial, _maxInteraxial);	
	}
	
	void DrawMinConvergenceField () {
		_minConvergence = EditorGUILayout.FloatField("Min Convergence", _minConvergence);
	}
	
	void DrawMaxConvergenceField () {
		_maxConvergence = EditorGUILayout.FloatField("Max Convergence", _maxConvergence);
	}
	
	void DrawConvergenceField () {
		_convergence = EditorGUILayout.Slider("Convergence", _convergence, _minConvergence, _maxConvergence);
	}
	
	void Draw3DModeField () {
		_sstate = (StereoState)EditorGUILayout.EnumPopup("3D Mode", _sstate);
	}
	
	bool DrawCreateButton () {
		return GUILayout.Button("Create");
	}
	
	void Create () {
		if (_cb == null) {
			if (sname.Length <= 0) 
				sname = "3D Camera";
			
			GameObject go = new GameObject(sname, typeof(CameraBody));
			_cb = go.GetComponent<CameraBody>();

            Undo.RegisterCreatedObjectUndo(go, "Created Camera");
		}
		
		_cb.CameraDescription = sname;
		
		Stereo3D s3d = _cb.gameObject.AddComponent<Stereo3D>();
		s3d.SelectedRig = _selectedRig;
		s3d.Interaxial = _interaxial;
		s3d.Convergence = _convergence;
		s3d.State = _sstate;
		
		Camera cam = _cb.NodalCamera;
		cam.nearClipPlane = 0.01f;
		
		cam.gameObject.AddComponent<Stereo3DRenderer>();
		
		SceneView sv = SceneView.lastActiveSceneView;
		
		if (sv == null)
			sv = SceneView.sceneViews[0] as SceneView;
		
		sv.Focus();
		Camera c = SceneView.GetAllSceneCameras()[0];
		
		_cb.transform.rotation = Quaternion.LookRotation(c.transform.forward);
		_cb.transform.position = c.transform.position;
	}
}
