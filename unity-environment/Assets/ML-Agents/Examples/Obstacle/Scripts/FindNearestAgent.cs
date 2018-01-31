using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FindNearestAgent : MonoBehaviour {

    public GameObject[] agents;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        float minDistance = 25f;
        int chosen = 0;
        for (int i= 0; i<agents.Length; i++)
        {
            float tempDistance = Mathf.Sqrt(Mathf.Pow((agents[i].transform.position.x - transform.position.x), 2) + Mathf.Pow((agents[i].transform.position.z - transform.position.z), 2));
            if(tempDistance < minDistance)
            {
                chosen = i;
                minDistance = tempDistance;
            }
        }
        PedestriansAgent script = GetComponent<PedestriansAgent>();
        //script.obstacles[0] = agents[chosen];
        script.setObstacle(agents[chosen]);
	}
}
