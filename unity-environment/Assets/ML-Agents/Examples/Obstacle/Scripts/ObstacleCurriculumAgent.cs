using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;

public class ObstacleCurriculumAgent : Agent
{
    [SerializeField]
    private float agentX;
    [SerializeField]
    private float agentZ;
    [SerializeField]
    private float obstacleX;
    [SerializeField]
    private float obstacleZ;
    [SerializeField]
    private float goalX;
    [SerializeField]
    private float goalZ;
    [SerializeField]
    private Text trainingText;
    [SerializeField]
    private Text cumulativeText;
    [SerializeField]
    private GameObject agent;
    [SerializeField]
    private GameObject obstacle;
    [SerializeField]
    private GameObject goal;

    public float directionX, directionZ;
    public int seed;

    private int solved = 0, failures = 0, obstacleHit = 0;
    private string state = "OK";
    private bool isDone = false;
    private float length = 14, width = 4;
    private float step = 0.5f;

    //Distances: http://changingminds.org/techniques/body/social_distance.htm
    private float maxDistance = 25;
    private float completionDistance = 2f;
    private static float agentRadius = 1f;
    private float socialZone = 3.5f + agentRadius;  //e.g. I'm in social zone if obstacleDistance <= socialZone
    private float personalZone = 1.5f + agentRadius;
    private float intimateZone = 0.5f + agentRadius;

    void Start()
    {
        seed = 42;
        UnityEngine.Random.InitState(seed);
    }

    float calculateReward(float distance, float obstacleDistance)
    {
        if (distance <= completionDistance) 
        {
            solved += 1;
            reward = 1f;
            isDone = true;
            state = "DONE";
        }
        else if (distance > maxDistance && !isDone)
        {
            failures += 1;
            state = "TOO FAR";
            reward = -1f;
            isDone = true;
        }

        else if (Mathf.Abs(agentX) > length || Mathf.Abs(agentZ) > width)
        {
            reward = -(step/50);
            state = "OUT";
        }

        else if (obstacleDistance <= intimateZone)
        {
            obstacleHit += 1;
            reward = -1f;
            isDone = true;
            state = "INTIMATE ZONE";
        }

        else if (obstacleDistance < personalZone)
        {
            reward = -(step / 50);
            state = "PERSONAL ZONE";
        }

        else if (obstacleDistance < socialZone)
        {
            reward = -(step / 75);
            state = "SOCIAL ZONE";
        }

        else
        {
            reward = -(step/100);
            state = "OK";
        }
        return reward;
    }

    public override List<float> CollectState()
    {
        List<float> state = new List<float>();

        state.Add(transform.position.x);
        state.Add(transform.position.y);
        state.Add(transform.position.z);

        state.Add(obstacle.transform.position.x);
        state.Add(obstacle.transform.position.y);
        state.Add(obstacle.transform.position.z);

        state.Add(goal.transform.position.x);
        state.Add(goal.transform.position.y);
        state.Add(goal.transform.position.z);
        
        return state;
    }

    public override void AgentStep(float[] action)
    {
        switch ((int)action[0])
        {
            case 0:
                agentX -= step;
                break;
            case 1:
                agentX += step;
                break;
            case 2:
                agentZ -= step;
                break;
            case 3:
                agentZ += step;
                break;
            case 4:
                agentX -= step / 2;
                agentZ += step / 2;
                break;
            case 5:
                agentX += step / 2;
                agentZ += step / 2;
                break;
            case 6:
                agentX -= step / 2;
                agentZ -= step / 2;
                break;
            case 7:
                agentX += step / 2;
                agentZ -= step / 2;
                break;
            default:
                return;
        }

        obstacleX += UnityEngine.Random.Range(-step, step/2);
        obstacleZ += UnityEngine.Random.Range(-step, step);

        agent.transform.position = new Vector3(agentX, 0, agentZ);
        obstacle.transform.position = new Vector3(obstacleX, 0, obstacleZ);
        goal.transform.position = new Vector3(goalX, 0, goalZ);

        float distance = Mathf.Sqrt(Mathf.Pow((goalX - agentX), 2) + Mathf.Pow((goalZ - agentZ), 2));
        float obstacleDistance = Mathf.Sqrt(Mathf.Pow((obstacleX - agentX), 2) + Mathf.Pow((obstacleZ - agentZ), 2));

        reward = calculateReward(distance, obstacleDistance);

        Monitor.Log("Reward", reward, MonitorType.slider, agent.transform);
        Monitor.Log("Distance", distance/maxDistance, MonitorType.slider, agent.transform);
        Monitor.Log("Obstacle Distance", obstacleDistance/3, MonitorType.slider, agent.transform);
        Monitor.Log("State", state, MonitorType.text, agent.transform);

        if (trainingText != null)
        {
            trainingText.text = string.Format("D:{0} / OD:{1} / R:{2} [{3};{4};{5}]", distance, obstacleDistance, reward, solved, failures, obstacleHit);
        }
        if(cumulativeText != null)
        {
            cumulativeText.text = string.Format("CR:{0} / S:{1}", CumulativeReward, state);
        }
        
        if (isDone)
        {
            done = true;
            isDone = false;
            return;
        }
        
    }

    public override void AgentReset()
    {
        agentX = UnityEngine.Random.Range(-10, -14);
        agentZ = UnityEngine.Random.Range(4, -4);

        obstacleX = UnityEngine.Random.Range(7, -7);
        obstacleZ = UnityEngine.Random.Range(4, -4);

        //goalX = UnityEngine.Random.Range(10, 14);
        //goalZ = UnityEngine.Random.Range(4, -4);
        
        goalX = 10f;
        goalZ = 0;
    }
}
