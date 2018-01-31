using UnityEngine;
using System.Collections;

public class ShakeCam : MonoBehaviour {
	
	public float positionShakeSpeed = 0.1f;
    public Vector3 positionShakeRange = new Vector3(0.1f, 0.1f, 0.1f);
	
	public float rotationShakeSpeed = 0.1f;
	public Vector3 rotationShakeRange = new Vector3(4.0f, 4.0f, 4.0f);
	
	private Vector3 position;
	private Quaternion initialRotation;
	
	private Quaternion rotationQuat;
	
	public enum NoiseType { None, Position, Rotation, Dual };
	public NoiseType type = NoiseType.Dual;
	
	void Start () {
		// store the initial position and rotation of the game object
		position = transform.localPosition;
		rotationQuat = initialRotation = transform.localRotation;
	}
	
	// Update is called once per frame
	void Update () {
		if (type == NoiseType.Position || type == NoiseType.Dual) {
			ShakePosition();
		}
		
		if (type == NoiseType.Rotation || type == NoiseType.Dual) {
			ShakeRotation();
		}
	}
	
	
	public void ShakeRotation () {
		/*
		 * This set rotationQuat equal to a pseudo-random rotation by taking the initial rotation(in Euler Angle format)
		 * and adding a scaled Vector3 to it. The Vector3 is created by calling the SmoothRandom.GetVector3 function from
		 * the Perlin script and multiplying the resultant Vector3 by the range to shake across. Then update the localRotation
		 * to the new rotationQuat value.
		 * 
		 */
		rotationQuat = Quaternion.Euler(initialRotation.eulerAngles + Vector3.Scale(SmoothRandom.GetVector3(rotationShakeSpeed), rotationShakeRange));
		transform.localRotation = rotationQuat;
	}
	
	public void ShakePosition () {
		/*
		 * Update the localPosition by taking the original localPosition and adding a scaled Vector3.
		 * The Vector3 is calculated by calling the SmoothRandom.GetVector3 function from the Perlin
		 * script, which returns a pseudo-random Vector3 based on the given inputs.
		 */
		transform.localPosition = position + Vector3.Scale(SmoothRandom.GetVector3(positionShakeSpeed), positionShakeRange);
	}
}