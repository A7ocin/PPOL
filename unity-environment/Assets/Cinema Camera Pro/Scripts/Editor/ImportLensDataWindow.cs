using UnityEditor;
using UnityEngine;

public class ImportLensDataWindow : EditorWindow {
		
	private TextAsset csv;
	
	[MenuItem ("Window/Cinema Suite/Cinema Pro Cams/Refresh Lens Data", false, 200)]
	public static void ImportLensData() {
		ProCamsLensDataTable.Instance.LoadData();
		Debug.Log ("Lens Data Updated!");
	}
}