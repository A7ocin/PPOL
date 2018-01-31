using UnityEngine;
using UnityEngine.EventSystems;
using System;
using System.Collections;
using System.Collections.Generic;
using OpenCVForUnityExample;
using UnityEngine.SceneManagement;


public class CameraControllerPTZ : MonoBehaviour {

    public float tempo;

    public Tracking c;
    public float x_coordinate;
    public float y_coordinate;

    public bool enableTracking = false;
    public bool loop;

    public float speedZoomIn = 0.3f;
	public float speedZoomOut = 0.3f;

	public float verSpeed = 2.0F;
	public float horSpeed = 2.0F;

    private float damping = 1;

    public Transform target;

    public float posInizx;
    public float posInizy;
    private float posInizz;
    private float posInizFOV;

    private Vector3 starting_position;
    private float starting_FOV;
    public bool backToStart = false;

    private float xRotate;
	private float yRotate;
	private float zRotate;

	private Vector3 currentRotation;

	private float minX;
	private float maxX;
	private float minY;
	private float maxY;

	private float height0;

	private int counter;

    private Vector3 offset;

    private void Start()
	{
		counter = 0;
		height0 = 0;
        Vector3 currentRotation = transform.rotation.eulerAngles;
        posInizx = currentRotation.x;
        posInizy = currentRotation.y;
        posInizz = currentRotation.z;
        posInizFOV = GetComponent<Camera>().fieldOfView;
        Debug.Log("x " + posInizx + ", y " + posInizy + ", z " + posInizz + ", zoom" + posInizFOV);


        Vector3 point = new Vector3(Screen.width/2, Screen.height/2, 0);
        Ray ray = Camera.main.ScreenPointToRay(point);
        RaycastHit hit;
        Physics.Raycast(ray, out hit);
        Debug.DrawRay(ray.origin, ray.direction * 10, Color.green);
        Vector3 point2 = new Vector3(point.x, point.y, hit.distance);
        starting_position = Camera.main.ScreenToWorldPoint(point2);
        starting_FOV = Camera.main.fieldOfView;
        //Debug.Break();
    }
    
    void LateUpdate()
	{
        
        //int d = Tracking.FindObjectOfType<Tracking>().GetComponent<Tracking>().d;
        bool CamShiftOn = Tracking.FindObjectOfType<Tracking>().GetComponent<Tracking>().CamShiftOn;
        /*if (Input.GetMouseButtonDown(0) && (Input.mousePosition.x >= d) && (Input.mousePosition.y >= d) && (Input.mousePosition.x <= Screen.width - d) && (Input.mousePosition.y <= Screen.height - d))
        {
            enableTracking = false;
            tempo = 0;

        }
        if (Input.GetMouseButtonUp(0))
        {
            tempo = 0;
        }*/

        //tempo += Time.deltaTime;
        //Debug.Log(CamShiftOn);
        if (CamShiftOn) // se la camera è in movimento al clic del mouse si ferma per mezzo secondo per permettere di selezionare il riquadro con il mouse
        {
            enableTracking = true;
        }
        else
        {
            enableTracking = false;
        }

        //*********** rotazione camera ***************
        float rotationX = Input.GetAxis("Vertical") * verSpeed;
        float rotationY = Input.GetAxis("Horizontal") * horSpeed;

        rotationX *= Time.deltaTime;
        rotationY *= Time.deltaTime;
        transform.Rotate(-rotationX, 0, 0);                                 //rotazione x
        transform.Rotate(0, rotationY, 0);                                  //rotazione y
        Vector3 currentRotation = transform.rotation.eulerAngles;
        currentRotation.z = Mathf.Clamp(currentRotation.z, 0f, 0f);     //limite rotazione z ( rotation = 0)
        transform.rotation = Quaternion.Euler(currentRotation);

        //*********** end rotazione camera ***************


        //******** zoom *********

        /*if (Input.GetAxis ("Mouse ScrollWheel") > 0) {
			GetComponent<Camera>().fieldOfView--;
		} 

		if (Input.GetAxis ("Mouse ScrollWheel") < 0) {
			GetComponent<Camera>().fieldOfView++;
		}*/
        GetComponent<Camera>().fieldOfView = Mathf.Clamp(GetComponent<Camera>().fieldOfView, 10f, 90f); //***************limita zoom

        //********* end zoom *************

        x_coordinate = Tracking.FindObjectOfType<Tracking>().GetComponent<Tracking>().x_coordinate_for_camera; //* horSpeed;
        y_coordinate = Tracking.FindObjectOfType<Tracking>().GetComponent<Tracking>().y_coordinate_for_camera; // * verSpeed;
        float height = Tracking.FindObjectOfType<Tracking>().GetComponent<Tracking>().height;
        float width = Tracking.FindObjectOfType<Tracking>().GetComponent<Tracking>().width;

        //float x_coordinate = script.FindObjectOfType<script> ().GetComponent<script> ().x_coordinate;
        //float y_coordinate = script.FindObjectOfType<script> ().GetComponent<script> ().y_coordinate;


        if (enableTracking)
        {
            height0 = height;
            counter++;
            //Debug.Log ("height0" + height0);
        }


        if (enableTracking)
        {
            backToStart = false;
            //Vector3 top_left_pos = new Vector3(out_rect.x, Screen.height - out_rect.y);
            //Vector3 bottom_right_pos = new Vector3(out_rect.x + out_rect.width, Screen.height - (out_rect.y + out_rect.height));
            Vector3 point = new Vector3(x_coordinate, Screen.height - y_coordinate, 0);
            Ray ray = Camera.main.ScreenPointToRay(point);
            RaycastHit hit;
            Physics.Raycast(ray, out hit);
            Debug.DrawRay(ray.origin, ray.direction * 10, Color.green);
            Vector3 point2 = new Vector3(point.x, point.y, hit.distance);
            Vector3 objPosition = Camera.main.ScreenToWorldPoint(point2);
            Debug.Log("objPosition" + objPosition);
            //objPosition.y = 0;

            var rotation = Quaternion.LookRotation(objPosition - transform.position);
            transform.rotation = Quaternion.Slerp(transform.rotation, rotation, Time.deltaTime * damping);
            //transform.LookAt(objPosition);



            if ((height <= height0 / 4  || height <= Screen.height/4) && height != 0)
            {
                Camera.main.fieldOfView--;
                Debug.Log("Zoom in");
            }
            if ((height > height0 || height >= Screen.height / 3) && height != 0)
            {
                Camera.main.fieldOfView = Camera.main.fieldOfView + speedZoomOut;
                Debug.Log("Zoom out");
            }

             int iterNum = Tracking.FindObjectOfType<Tracking>().GetComponent<Tracking>().Numiter; //impostato a 100.
             int iter = Tracking.FindObjectOfType<Tracking>().GetComponent<Tracking>().iter;
                
                /*
                if (((width >= Screen.width - 10) || (height >= Screen.height - 10) && iter == iterNum) && loop)
                {
                    string currentSceneName = SceneManager.GetActiveScene().name;
                    SceneManager.LoadScene(currentSceneName);
                    Debug.Log("Lost obj");
                    enableTracking = false;
                }*/
            
        }
        else
        {

            backToStart = true;
            Quaternion rotation = Quaternion.LookRotation(starting_position - transform.position);

            if (posInizx - currentRotation.x > 1 || posInizy - currentRotation.y > 1 || posInizz - currentRotation.z > 1)
            {
                transform.rotation = Quaternion.Slerp(transform.rotation, rotation, Time.deltaTime * damping);
                backToStart = false;
            } 
            

            if (Camera.main.fieldOfView > starting_FOV && Camera.main.fieldOfView - starting_FOV > 1)
            {
                Camera.main.fieldOfView--;
                Debug.Log("Zoom in");
                backToStart = false;
            }
            else if (Camera.main.fieldOfView < starting_FOV && starting_FOV - Camera.main.fieldOfView > 1)
            {
                Camera.main.fieldOfView++;
                Debug.Log("Zoom out");
                backToStart = false;
            }

        }
        //Debug.Log("zoom" + Camera.main.fieldOfView);
    }
}