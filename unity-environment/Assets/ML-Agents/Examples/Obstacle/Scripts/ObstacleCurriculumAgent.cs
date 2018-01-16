﻿using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;

public class ObstacleCurriculumAgent : Agent
{
    [SerializeField]
    private float agentX;
    [SerializeField]
    private float agentZ;
    //[SerializeField]
    //private float obstacleX;
    //[SerializeField]
    //private float obstacleZ;
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
    private GameObject[] obstacles;
    [SerializeField]
    private GameObject goal;
    [SerializeField]
    private GameObject area;

    public float directionX, directionZ;
    public int seed;

    private int solved = 0, failures = 0, obstacleHit = 0;
    private string state = "OK";
    private bool isDone = false;
    private float length = 14, width = 4, spawnZone = 10;
    private float step = 0.1f;

    //Distances: http://changingminds.org/techniques/body/social_distance.htm
    private float maxDistance = 25;
    private float completionDistance = 2f;
    private static float agentRadius = 1f;
    private float socialZone = 3.5f + agentRadius;  //e.g. I'm in social zone if obstacleDistance <= socialZone
    private float personalZone = 1.5f + agentRadius;
    private float intimateZone = 0.5f + agentRadius;

    private float previousDistance = 25;

    void Start()
    {
        seed = 42;
        UnityEngine.Random.InitState(seed);
        //length = directionX * length;
        //width = directionZ * width;
        //spawnZone = directionX * spawnZone;
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

        else if (obstacleDistance <= intimateZone)
        {
            obstacleHit += 1;
            reward = -1f;
            //isDone = true;
            state = "INTIMATE ZONE";
        }

        else if (obstacleDistance <= personalZone)
        {
            reward = -(step / 50);
            state = "PERSONAL ZONE";
        }

        else if (obstacleDistance <= socialZone)
        {
            reward = -(step / 75);
            state = "SOCIAL ZONE";
        }
        
        else if (Mathf.Abs(agentX) > length || Mathf.Abs(agentZ) > width)
        {
            reward = -(step / 50);
            state = "OUT ";
        }

        else if (distance <= previousDistance)
        {
            previousDistance = distance;
            reward += step / 100;
        }

        else
        {
            reward = -(step / 100);
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

        foreach (GameObject obstacle in obstacles)
        {
            state.Add(obstacle.transform.position.x);
            state.Add(obstacle.transform.position.y);
            state.Add(obstacle.transform.position.z);
        }

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
                agentX -= directionX * step;
                break;
            case 1:
                agentX += directionX * step;
                break;
            case 2:
                agentZ -= directionZ * step;
                break;
            case 3:
                agentZ += directionZ * step;
                break;
            case 4:
                agentX -= directionX * step / 2;
                agentZ += directionZ * step / 2;
                break;
            case 5:
                agentX += directionX * step / 2;
                agentZ += directionZ * step / 2;
                break;
            case 6:
                agentX -= directionX * step / 2;
                agentZ -= directionZ * step / 2;
                break;
            case 7:
                agentX += directionX * step / 2;
                agentZ -= directionZ * step / 2;
                break;
            default:
                return;
        }

        float obstacleDistance = 0;
        float[] tempObstacleDistances = new float[obstacles.Length];

        for(int i=0; i<obstacles.Length; i++)
        {
            //obstacleX += UnityEngine.Random.Range(-directionX * step, directionX * step / 2);
            //obstacleZ += UnityEngine.Random.Range(-directionZ * step, directionZ * step);
            //obstacles[i].transform.position = new Vector3(obstacleX, 0, obstacleZ);
            obstacles[i].transform.position = new Vector3(
                obstacles[i].transform.position.x + UnityEngine.Random.Range(-directionX * step, directionX * step / 2),
                0,
                obstacles[i].transform.position.z + UnityEngine.Random.Range(-directionZ * step, directionZ * step));
            tempObstacleDistances[i] = Mathf.Sqrt(Mathf.Pow((obstacles[i].transform.position.x - agentX), 2) + Mathf.Pow((obstacles[i].transform.position.z - agentZ), 2));
            //if(tempObstacleDistance < obstacleDistance)
            //{
            //    obstacleDistance = tempObstacleDistance;
            //}
            //if (tempObstacleDistances[i] <= personalZone)
            //{
            //    obstacleDistance = tempObstacleDistances[i];
            //}
            //else
            //{
            //    obstacleDistance += tempObstacleDistances[i];
            //}
        }
        obstacleDistance = tempObstacleDistances.Min();
        //obstacleDistance = obstacleDistance / obstacles.Length;

        agent.transform.position = new Vector3(agentX, 0, agentZ);
        goal.transform.position = new Vector3(goalX, 0, goalZ);

        float distance = Mathf.Sqrt(Mathf.Pow((goalX - agentX), 2) + Mathf.Pow((goalZ - agentZ), 2));
        //float obstacleDistance = Mathf.Sqrt(Mathf.Pow((obstacleX - agentX), 2) + Mathf.Pow((obstacleZ - agentZ), 2));

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
        float areaZ = area.transform.position.z;
        /**Invert direction**/
        //directionX = -directionX;
        //directionZ = -directionZ;
        /****/

        spawnZone = directionX * Mathf.Abs(spawnZone);

        agentX = UnityEngine.Random.Range(-spawnZone, -directionX * length);
        agentZ = areaZ + UnityEngine.Random.Range(width, -width);

        //obstacleX = UnityEngine.Random.Range(length/2, -length/2);
        //obstacleZ = UnityEngine.Random.Range(width, -width);

        for (int i = 0; i < obstacles.Length; i++)
        {
            obstacles[i].transform.position = new Vector3(
                UnityEngine.Random.Range(length / 2, -length / 2),
                0,
                areaZ + UnityEngine.Random.Range(width, -width));
        }

        //goalX = UnityEngine.Random.Range(10, 14);
        //goalZ = UnityEngine.Random.Range(4, -4);

        goalX = spawnZone;
        goalZ = areaZ;
    }
}
