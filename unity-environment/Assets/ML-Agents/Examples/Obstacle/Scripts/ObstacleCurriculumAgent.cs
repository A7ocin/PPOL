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
    public string state = "OK";

    public int seed;

    int solved = 0, failures = 0, obstacleHit = 0;
    public float maxDistance = 25;
    public bool isDone = false;

    void Start()
    {
        seed = 42;
        UnityEngine.Random.InitState(seed);
    }

    float calculateReward(float distance, float obstacleDistance)
    {
        if (distance < 2f) 
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

        else if (agentX > 14 || agentX < -14 || agentZ > 4 || agentZ < -4)
        {
            reward = -0.01f;
            state = "OUT";
        }

        else if (obstacleDistance <= 2)
        {
            obstacleHit += 1;
            reward = -1f;
            isDone = true;
            state = "COLLIDED";
        }

        else if (obstacleDistance < 5)
        {
            reward = -0.01f;
            state = "NEAR OBSTACLE";
        }

        else
        {
            reward = -0.005f;
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
                agentX -= 0.5f;//= Mathf.SmoothDamp(agentX, agentX - directionX * 1.0f, ref velocity, 0.1f);
                break;
            case 1:
                agentX += 0.5f;//= Mathf.SmoothDamp(agentX, agentX + directionX * 1.0f, ref velocity, 0.1f);
                break;
            case 2:
                agentZ -= 0.5f;//= Mathf.SmoothDamp(agentZ, agentZ - directionZ * 1.0f, ref velocity, 0.1f);
                break;
            case 3:
                agentZ += 0.5f;//= Mathf.SmoothDamp(agentZ, agentZ + directionZ * 1.0f, ref velocity, 0.1f);
                break;
            case 4:
                agentX -= 0.25f;
                agentZ += 0.25f;
                break;
            case 5:
                agentX += 0.25f;
                agentZ += 0.25f;
                break;
            case 6:
                agentX -= 0.25f;
                agentZ -= 0.25f;
                break;
            case 7:
                agentX += 0.25f;
                agentZ -= 0.25f;
                break;
            default:
                return;
        }
        //UnityEngine.Random.InitState(2000);
        obstacleX += UnityEngine.Random.Range(-0.5f, 0.02f);
        obstacleZ += UnityEngine.Random.Range(-0.5f, 0.5f);

        agent.transform.position = new Vector3(agentX, 0, agentZ);
        obstacle.transform.position = new Vector3(obstacleX, 0, obstacleZ);
        goal.transform.position = new Vector3(goalX, 0, goalZ);

        float distance = Mathf.Sqrt(Mathf.Pow((goalX - agentX), 2) + Mathf.Pow((goalZ - agentZ), 2));
        //float distance = Mathf.Abs(goalX - agentX);
        float obstacleDistance = Mathf.Sqrt(Mathf.Pow((obstacleX - agentX), 2) + Mathf.Pow((obstacleZ - agentZ), 2));

        float tempReward = calculateReward(distance, obstacleDistance);
        //if (!isDone) {
        //    reward = tempReward / 10;
        //}
        //else
        //{
            reward = tempReward;
        //}

        Monitor.Log("Reward", reward, MonitorType.slider, agent.transform);
        Monitor.Log("Distance", distance/maxDistance, MonitorType.slider, agent.transform);
        Monitor.Log("Obstacle Distance", obstacleDistance/3, MonitorType.slider, agent.transform);

        if (trainingText != null)
        {
            trainingText.text = string.Format("D:{0} / OD:{1} / TR:{2} / R:{3} [{4};{5};{6}]", distance, obstacleDistance, tempReward, reward, solved, failures, obstacleHit);
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
