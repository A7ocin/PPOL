using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;

public class CrossingAgent : Agent
{
    public GameObject[] others;
    public GameObject myGoal;
    public GameObject otherGoal;
    public GameObject area;
    public GameObject monitor;
    public float originalX, originalZ, otherX;
    public float speed = 10f;
    public Text trainingText;

    //Distances: http://changingminds.org/techniques/body/social_distance.htm
    private static float agentRadius = 0.5f;
    private float socialZone = 3f + agentRadius;  //e.g. I'm in social zone if obstacleDistance <= socialZone
    private float personalZone = 1.5f + agentRadius;
    private float intimateZone = 0.5f + agentRadius;

    private int solved = 0, failures = 0;

    private int seed = 42;
    private float prevDistance = 25;

    void Start()
    {
        seed = 42;
        UnityEngine.Random.InitState(seed);
    }

    public void MoveAgent(float[] act)
    {
        float directionX = 0;
        float directionZ = 0;

        int movement = Mathf.FloorToInt(act[0]);
        if (movement == 1) { directionX = -1; }
        if (movement == 2) { directionX = 1; }
        if (movement == 3) { directionZ = -1; }
        if (movement == 4) { directionZ = 1; }

        gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(directionX * speed, 0f, directionZ * speed));
        if (GetComponent<Rigidbody>().velocity.sqrMagnitude > 25f)
        {
            GetComponent<Rigidbody>().velocity *= 0.95f;
        }
    }

    public override List<float> CollectState()
    {
        List<float> state = new List<float>();

        state.Add(transform.position.x);
        state.Add(transform.position.z);

        foreach(GameObject other in others)
        {
            state.Add(other.transform.position.x);
            state.Add(other.transform.position.z);
        }

        state.Add(myGoal.transform.position.x);
        state.Add(myGoal.transform.position.z);

        return state;
    }

    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject == myGoal)
        {
            done = true;
            reward = 1f;
            solved += 1;
        }
    }

    public override void AgentStep(float[] action)
    {
        float[] obstacleDistances = new float[others.Length];
        float distance = Mathf.Abs(myGoal.transform.position.x - transform.position.x);

        for (int i = 0; i < others.Length; i++)
        {
            if (!others[i].activeSelf)
            {
                Debug.Log("There are some unactive agents!");
                obstacleDistances[i] = 10*socialZone;
                reward = -0.005f;
            }
            else
            {
                obstacleDistances[i] = Mathf.Sqrt(Mathf.Pow((others[i].transform.position.x - transform.position.x), 2) + Mathf.Pow((others[i].transform.position.z - transform.position.z), 2));
                if (obstacleDistances[i] <= intimateZone)
                {
                    //reward = -0.050f;
                    done = true;
                    reward = -1f;
                    failures += 1;
                }
                else if (obstacleDistances[i] <= personalZone) { reward = -0.010f; }
                else if (obstacleDistances[i] <= socialZone) { reward = -0.0075f; }
                else if (distance <= prevDistance)
                {
                    prevDistance = distance;
                    reward = 0.005f;
                }
                else {
                    prevDistance = distance;
                    reward = -0.005f;
                }
            }
        }

        MoveAgent(action);

        if (transform.position.y < 0.0f
            || Mathf.Abs(transform.position.x - area.transform.position.x) > 10f
            || Mathf.Abs(transform.position.z - area.transform.position.z) > 5f
            )
        {
            done = true;
            reward = -1f;
            failures += 1;
        }

        Monitor.Log("Reward", reward, MonitorType.slider, monitor.transform);
        Monitor.Log("OtherDistance", obstacleDistances.Min(), MonitorType.slider, monitor.transform);

        if (trainingText != null)
        {
            trainingText.text = string.Format("R:{0} [{1};{2}]", reward, solved, failures);
        }

    }

    public override void AgentReset()
    {
        float temp = originalX;
        originalX = otherX;
        otherX = temp;
        GameObject tempGO = myGoal;
        myGoal = otherGoal;
        otherGoal = tempGO;
        transform.position = new Vector3(originalX, 0, area.transform.position.z + UnityEngine.Random.Range(-2f, 2f)) ;
        GetComponent<Rigidbody>().velocity = new Vector3(0f, 0f, 0f);
        prevDistance = 25;
    }
}
