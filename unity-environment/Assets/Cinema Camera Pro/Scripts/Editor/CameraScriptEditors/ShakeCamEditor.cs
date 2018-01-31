using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(ShakeCam))]
[CanEditMultipleObjects]
public class ShakeCamEditor : Editor
{
    private SerializedProperty positionShakeSpeed;
    private SerializedProperty positionShakeRange;
    private SerializedProperty rotationShakeSpeed;
    private SerializedProperty rotationShakeRange;
    private SerializedProperty noiseType;

    #region Language
    GUIContent positionShakeSpeedContent = new GUIContent("Position Shake Speed");
    GUIContent rotationShakeSpeedContent = new GUIContent("Rotation Shake Speed");
    #endregion

    public void OnEnable()
    {
        this.positionShakeSpeed = base.serializedObject.FindProperty("positionShakeSpeed");
        this.positionShakeRange = base.serializedObject.FindProperty("positionShakeRange");
        this.rotationShakeSpeed = base.serializedObject.FindProperty("rotationShakeSpeed");
        this.rotationShakeRange = base.serializedObject.FindProperty("rotationShakeRange");
        this.noiseType = base.serializedObject.FindProperty("type");
    }

    public override void OnInspectorGUI()
    {
        base.serializedObject.Update();

        EditorGUILayout.Slider(positionShakeSpeed, 0.01f, 10f, positionShakeSpeedContent);
        EditorGUILayout.PropertyField(positionShakeRange);

        EditorGUILayout.Slider(rotationShakeSpeed, 0.01f, 10f, rotationShakeSpeedContent);
        EditorGUILayout.PropertyField(rotationShakeRange);
        
        EditorGUILayout.PropertyField(noiseType);

        base.serializedObject.ApplyModifiedProperties();
    }
}
