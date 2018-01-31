using UnityEngine;
using UnityEditor;


[CustomEditor(typeof(CamerasManager))]
public class CamerasManager_Editor : Editor {

   private CamerasManager script;

   void OnEnable() {
      script = (CamerasManager) target;
   }

   public override void OnInspectorGUI() {

      GUILayout.BeginVertical("box");
      GUILayout.BeginHorizontal();
      GUILayout.Space(10);
      GUILayout.BeginVertical();
      script.enableVideoSave = EditorGUILayout.BeginToggleGroup("Save Video", script.enableVideoSave);
      //script.enableDataSave = EditorGUILayout.ToggleLeft("Save Data", script.enableDataSave);
      script.folder = EditorGUILayout.TextField("Folder", script.folder);
      GUILayout.EndVertical();
      GUILayout.EndHorizontal();
      GUILayout.EndVertical();
      

      GUILayout.BeginVertical("box");
      GUILayout.Space(10);

      GUILayout.BeginHorizontal();
      GUILayout.Space(10);
      script.frameRate = EditorGUILayout.IntField("Frame Rate", script.frameRate);
      if(script.frameRate < 5) {
         script.frameRate = 5;
      }
      GUILayout.EndHorizontal();

      GUILayout.Space(10);
      GUILayout.BeginHorizontal();
      GUILayout.Space(10);
      GUILayout.Label("Number of cameras: " + script.cameras.Count);
      if(GUILayout.Button("Add Camera")) {
         int num = 0;
         bool exist = true;
         while(exist) {
            exist = false;
            num++;
            for(int i=0; i<script.cameras.Count; i++) {
               if(string.Format("camera_{0:D03}", num) == script.cameras[i].Name) {
                  exist = true;
                  break;
               }
            }
         }
         script.cameras.Add(new CameraType(string.Format("camera_{0:D03}", num)));
      }

      GUILayout.Space(10);
      GUILayout.EndHorizontal();


      GUIStyle XButtonStyle = new GUIStyle(GUI.skin.button);
      XButtonStyle.normal.textColor = Color.red;
      XButtonStyle.fixedWidth = 25;

      for(int i = 0; i < script.cameras.Count; i++) {
         GUILayout.BeginVertical();
         GUILayout.BeginHorizontal();
         GUILayout.Space(10);
         GUILayout.Label("Name:", GUILayout.Width(40));
         script.cameras[i].Name = GUILayout.TextField(script.cameras[i].Name);
         if(GUILayout.Button("X", XButtonStyle)) {
            script.cameras.RemoveAt(i);
            return;
         }
         GUILayout.Space(10);
         GUILayout.EndHorizontal();

         GUILayout.BeginHorizontal();
         GUILayout.Space(54);
         if(script.cameras[i].Camera = (Camera) EditorGUILayout.ObjectField(script.cameras[i].Camera, typeof(Camera), true)) {
            script.cameras[i].Camera.rect = new Rect(Vector2.zero, EditorGUILayout.Vector2Field(string.Empty, new Vector2((int) script.cameras[i].Camera.rect.width, (int) script.cameras[i].Camera.rect.height), GUILayout.Width(120)));
         }
         GUILayout.Space(10);
         GUILayout.EndHorizontal();

         GUILayout.Space(10);
         GUILayout.EndVertical();
      }

      GUILayout.Space(10);
      GUILayout.EndVertical();
      EditorGUILayout.EndToggleGroup();

   }
}
