using UnityEngine;

[RequireComponent (typeof(Stereo3D))]
public class Stereo3DGUI : MonoBehaviour {

	Stereo3D _s3d;
	bool[] b;
	bool on = true;
	
	void Awake () {
		_s3d = GetComponent<Stereo3D>() as Stereo3D;	
	}
	
	// Use this for initialization
	void Start () {
		b = new bool[System.Enum.GetNames(typeof(StereoState)).Length];
	}
	
	void Update () {
		on = on ^ Input.GetKeyDown(KeyCode.U);
	}
	
	void OnGUI () {
		if (on) {
			DrawGUI();	
		}
	}
	
	void DrawGUI () {
		// 	Rig
		int hOffset = 50;
		// Convergence
		GUI.Label(new Rect(Screen.width / 2, Screen.height - hOffset - 40, 90, 20),"Convergence");
		_s3d.Convergence =
			GUI.HorizontalSlider(
				new Rect(Screen.width / 2 + 90,Screen.height - hOffset - 35,80,20),
				_s3d.Convergence, 
				_s3d.MinConvergence, 
				_s3d.MaxConvergence);
				
		// Interaxial
		GUI.Label(new Rect(Screen.width / 2, Screen.height - hOffset - 20, 90, 20),"Interaxial");
		_s3d.Interaxial =
			GUI.HorizontalSlider(
				new Rect(Screen.width / 2 + 90,Screen.height - hOffset - 15,80,20),
				_s3d.Interaxial, 
				_s3d.MinInteraxial, 
				_s3d.MaxInteraxial);
		
		// 3D Mode
		for(int i = 0; i < b.Length; i++) {
			bool tmp = b[i];
			
			if (b[i]) {
				GUI.Toggle(
					new Rect(Screen.width / 2 + 220, Screen.height - hOffset - 60 + (20*i),100,20), 
					b[i], 
					System.Enum.GetNames(typeof(StereoState))[i]);
			} else {
				b[i] =  
					GUI.Toggle(
						new Rect(Screen.width / 2 + 220, Screen.height - hOffset - 60 + (20*i),100,20), 
						b[i], 
						System.Enum.GetNames(typeof(StereoState))[i]);
			}
			
			if (b[i] && !tmp) {
				b = new bool[System.Enum.GetNames(typeof(StereoState)).Length];
				b[i] = true;
				_s3d.SetMode((StereoState)i);
			}
		}
	}
}
