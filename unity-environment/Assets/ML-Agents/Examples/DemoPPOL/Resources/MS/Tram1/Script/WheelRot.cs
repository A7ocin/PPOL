using UnityEngine;
using System.Collections;

public class WheelRot : MonoBehaviour {
	
	public float wheelSpeed = 0.1f;
	public GameObject[] wheels;
	
	
	[HideInInspector]
	public float TotalSpeed;	
	
	[HideInInspector]
	public float maxSpeed = 50.0f;
	
	
	private float baseNum = 1;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
		wheelRot();
	
	}
	
	
	void wheelRot(){
		
		
		baseNum += 1.0f ;
								
		if(wheelSpeed >= 0.4f){			
			wheelSpeed = 0.4f;
		}else if(wheelSpeed <= -0.4f){
			wheelSpeed = -0.4f;			
		}
				
		TotalSpeed = maxSpeed * wheelSpeed;
		
								
		for (int i=0; i < wheels.Length; i++){
			
			wheels[i].transform.rotation  = Quaternion.Euler ( baseNum * TotalSpeed, 0.0f, 0.0f);
																	
		}		
	}
}
