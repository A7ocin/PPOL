using UnityEditor;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;

[CustomEditor (typeof(Stereo3D))]
public class Stereo3DEditor : Editor {
	
	SerializedProperty		_selectedRig;
	string[]				_rigList;
	SerializedProperty		_minInteraxial;
	SerializedProperty		_maxInteraxial;
	SerializedProperty		_interaxial;
	
	SerializedProperty		_minConvergence;
	SerializedProperty		_maxConvergence;
	SerializedProperty		_convergence;
	SerializedProperty		_material;
	SerializedProperty		_sstate;
	
	void OnEnable () {
		_selectedRig = serializedObject.FindProperty("_selectedRig");
		_minInteraxial = serializedObject.FindProperty("_minInteraxial");
		_maxInteraxial = serializedObject.FindProperty("_maxInteraxial");
		_interaxial = serializedObject.FindProperty("_interaxial");
		_minConvergence = serializedObject.FindProperty("_minConvergence");
		_maxConvergence = serializedObject.FindProperty("_maxConvergence");
		_convergence = serializedObject.FindProperty("_convergence");
		_material = serializedObject.FindProperty("_stereoMaterial");
		_sstate = serializedObject.FindProperty("_sstate");
		
		_rigList = new string[]{ 
			"Tango",
			"TS5 3ality",
			"TS2 3ality"
		};
		
		Stereo3D s3d = target as Stereo3D;
		s3d.SetMode((StereoState)_sstate.intValue);
		
	} 
	
	public override void OnInspectorGUI () {
		serializedObject.Update();
		
		EditorGUILayout.BeginVertical("box");
		
		EditorGUILayout.LabelField("STEREOSCOPIC",EditorStyles.boldLabel);
		
		DrawMaterialField ();
		DrawRigField ();
		
		//EditorGUILayout.BeginHorizontal("box");
		//	DrawMinConvergenceField();
		//	DrawMaxConvergenceField();
		//EditorGUILayout.EndHorizontal();

		DrawConvergenceField();
		
		//EditorGUILayout.BeginHorizontal("box");
		//	DrawMinInteraxialField();
		//	DrawMaxInteraxialField();
		//EditorGUILayout.EndHorizontal();
		DrawInteraxialField();
		
		DrawShutterField();
		EditorGUILayout.EndVertical();
		
		
		serializedObject.ApplyModifiedProperties();
		if (GUI.changed) {
			EditorUtility.SetDirty(target);	
		}
		
	} 
	
	void OnSceneGUI () {
		Stereo3D s3d = target as Stereo3D;
		Camera c = SceneView.lastActiveSceneView.camera;
		s3d.ShowBody = Vector3.Distance(c.transform.position, s3d.transform.position) > 0.2f;
	}
	
	void DrawRigField () {
		_selectedRig.intValue = EditorGUILayout.Popup("Rigs", _selectedRig.intValue, _rigList);
	}
	
	void DrawMaterialField () {
		_material.objectReferenceValue = 
			EditorGUILayout.ObjectField("Stereo Material", _material.objectReferenceValue, typeof(Material), true);
	}
	
	void DrawMinConvergenceField () {
		_minConvergence.floatValue = EditorGUILayout.FloatField("Min Convergence", _minConvergence.floatValue);
	}
	void DrawMaxConvergenceField () {
		_maxConvergence.floatValue = EditorGUILayout.FloatField("Max Convergence", _maxConvergence.floatValue);
	}
	
	void DrawMinInteraxialField () {
		_minInteraxial.floatValue = EditorGUILayout.FloatField("Min Interaxial", _minInteraxial.floatValue);
	}
	
	void DrawMaxInteraxialField () {
		_maxInteraxial.floatValue = EditorGUILayout.FloatField("Max Interaxial", _maxInteraxial.floatValue);
	}
	
	void DrawInteraxialField () {
        EditorGUILayout.LabelField("Interaxial");
        EditorGUI.indentLevel++;
		_interaxial.floatValue = 
			EditorGUILayout.Slider(_interaxial.floatValue, _minInteraxial.floatValue, _maxInteraxial.floatValue);
        EditorGUI.indentLevel--;
	}
	
	void DrawConvergenceField () {
        EditorGUILayout.LabelField("Convergence");
        EditorGUI.indentLevel++;
		_convergence.floatValue = 
			EditorGUILayout.Slider(_convergence.floatValue, _minConvergence.floatValue, _maxConvergence.floatValue);
        EditorGUI.indentLevel--;
	}
	
	void DrawShutterField () {
		int checkVal = _sstate.intValue;
		StereoState st = (StereoState)checkVal;
		EditorGUILayout.BeginHorizontal("box");
		st =  (StereoState)EditorGUILayout.EnumPopup("3D Mode", st);
		EditorGUILayout.EndHorizontal();
		_sstate.enumValueIndex = (int)st;
		
		if (checkVal != _sstate.intValue) {
			Stereo3D s3d = target as Stereo3D;
			s3d.SetMode(st);
		}
	}
}
