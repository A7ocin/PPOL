using UnityEngine;

[RequireComponent (typeof(CameraBody))]
public class CameraBodyGUI : MonoBehaviour {
	
	CameraBody _cb;
	bool on = true;
	
	int hOffset = 50;
	int wOffset = 100;
	
	void Awake () {
		_cb = GetComponent<CameraBody>() as CameraBody;	
	}
	
	void Update () {
		on = on ^ Input.GetKeyDown(KeyCode.U);
	}
	
	void OnGUI () {
		if (on) {
			DrawGUI ();	
		}
	}
	
	void DrawGUI () {
		DrawFilmPlaneOffset();
		DrawFocusDistance();
		DrawFStop();
		DrawFocalLength();
	}
	
	/// <summary>
	/// Draws the film plane offset GUI.
	/// </summary>
	void DrawFilmPlaneOffset() {
	// Film Plane Offset
		Vector3 v = _cb.FilmPlaneOffset;
		GUI.Label(new Rect(wOffset,Screen.height - hOffset - 40,50,20),"fpo.x");
		GUI.Label(new Rect(wOffset,Screen.height - hOffset - 20,50,20),"fpo.y");
		GUI.Label(new Rect(wOffset,Screen.height - hOffset -  0,50,20),"fpo.z");
		if (GUI.RepeatButton(new Rect(50 + wOffset,Screen.height - hOffset - 40,20,20), "-"))
			v.x--;
		if (GUI.RepeatButton(new Rect(50 + wOffset,Screen.height - hOffset - 20,20,20), "-"))
			v.y--;
		if (GUI.RepeatButton(new Rect(50 + wOffset,Screen.height - hOffset -  0,20,20), "-"))
			v.z--;
		if (GUI.RepeatButton(new Rect(70 + wOffset,Screen.height - hOffset - 40,20,20), "+"))
			v.x++;
		if (GUI.RepeatButton(new Rect(70 + wOffset,Screen.height - hOffset - 20,20,20), "+"))
			v.y++;
		if (GUI.RepeatButton(new Rect(70 + wOffset,Screen.height - hOffset -  0,20,20), "+"))
			v.z++;
		_cb.FilmPlaneOffset = v;
	}
	
	/// <summary>
	/// Draws the focus distance GUI.
	/// </summary>
	void DrawFocusDistance() {
		GUI.Label(new Rect(100 + wOffset,Screen.height - hOffset - 40,50,20),"f dist");
		// Focus Distance
		if (GUI.RepeatButton(new Rect(150 + wOffset,Screen.height - hOffset - 40,20,20), "-"))
			_cb.FocusDistance--;
		if (GUI.RepeatButton(new Rect(170 + wOffset,Screen.height - hOffset - 40,20,20), "+"))
			_cb.FocusDistance++;
	}
	
	/// <summary>
	/// Draws the F stop GUI.
	/// </summary>
	void DrawFStop() {
		// F-Stop
		GUI.Label(new Rect(100 + wOffset,Screen.height - hOffset - 20,50,20),"fstop");
		if (GUI.Button(new Rect(150 + wOffset,Screen.height - hOffset - 20,20,20), "-")) {
			if (_cb.IndexOfFStop > 0)
				_cb.IndexOfFStop--;
		}
				
		if (GUI.Button(new Rect(170 + wOffset,Screen.height - hOffset - 20,20,20), "+")) {
			if (_cb.IndexOfFStop < FStop.list.Length)
				_cb.IndexOfFStop++;
		}	
	}
	
	/// <summary>
	/// Draws the length of the focal GUI.
	/// </summary>
	void DrawFocalLength() {
		// Focal Length
		GUI.Label(new Rect(100 + wOffset,Screen.height - hOffset,50,20),"f length");
		if (GUI.Button(new Rect(150 + wOffset,Screen.height - hOffset,20,20), "-"))
			_cb.IndexOfLens--;
		if (GUI.Button(new Rect(170 + wOffset,Screen.height - hOffset,20,20), "+"))
			_cb.IndexOfLens++;
	}
}
