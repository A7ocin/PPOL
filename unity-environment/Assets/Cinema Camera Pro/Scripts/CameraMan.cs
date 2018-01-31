using UnityEngine;

public class CameraMan : MonoBehaviour {
	
	public float	moveSpeed;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.W)) {
			transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);	
		}
		
		if (Input.GetKey(KeyCode.A)) {
			transform.Translate(Vector3.left * moveSpeed * Time.deltaTime);
		}
		
		if (Input.GetKey(KeyCode.S)) {
			transform.Translate(Vector3.back * moveSpeed * Time.deltaTime);
		}
		
		if (Input.GetKey(KeyCode.D)) {
			transform.Translate(Vector3.right * moveSpeed * Time.deltaTime);
		}
		
	
		
		float x = Input.GetAxis("Mouse X") * 40f * Time.deltaTime;
		float y = Input.GetAxis("Mouse Y") * -40f * Time.deltaTime;
		
		Quaternion qx = Quaternion.AngleAxis (x, Vector3.up);
		Quaternion qy = Quaternion.AngleAxis (y, Vector3.right);
		
		if (Input.GetMouseButton(0))
			transform.localRotation *= qx * qy;
		
	}
}
