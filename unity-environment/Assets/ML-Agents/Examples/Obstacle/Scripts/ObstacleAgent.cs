using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObstacleAgent : Agent {

    [SerializeField]
    private float currentX;
    [SerializeField]
    private float currentZ;
    [SerializeField]
    private float goalX;
    [SerializeField]
    private float goalZ;
    [SerializeField]
    private float obstacleX;
    [SerializeField]
    private float obstacleZ;
    [SerializeField]
    private Text text;
    [SerializeField]
    private Transform agent;
    [SerializeField]
    private Transform goal;
    [SerializeField]
    private Transform obstacle;

    int solved;
    public bool goalReached = false;

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "goal")
        {
            goalReached = true;
        }
    }

    public override List<float> CollectState()
    {
        List<float> state = new List<float>();
        state.Add(currentX);
        state.Add(currentZ);
        state.Add(obstacleX);
        state.Add(obstacleZ);
        state.Add(goalX);
        state.Add(goalZ);
        return state;
    }

    public override void AgentStep(float[] action)
    {
        if (text != null)
        {
            text.text = string.Format("C:{0}--{1} / O:{2}--{3} [{4}])", currentX, currentZ, obstacleX, obstacleZ, solved);
        }

        switch ((int)action[0])
        {
            case 0:
                currentX -= 0.5f;
                break;
            case 1:
                currentX += 0.5f;
                break;
            case 2:
                currentZ -= 0.5f;
                break;
            case 3:
                currentZ += 0.5f;
                break;
            default:
                return;
        }

        agent.position = new Vector3(currentX, 1f, currentZ);
        obstacle.position = new Vector3(obstacleX, 0.5f, obstacleZ);
        goal.position = new Vector3(goalX, 0.5f, goalZ);

        float distance = Mathf.Sqrt(Mathf.Pow((goalX - currentX), 2) + Mathf.Pow((goalZ - currentZ), 2));
        float obstacleDistance = Mathf.Sqrt(Mathf.Pow((obstacleX - currentX), 2) + Mathf.Pow((obstacleZ - currentZ), 2));

        if (distance <= 2f || goalReached)
        {
            solved += 1;
            reward = 1;
            goalReached = false;
            done = true;
            return;
        }
        else if (obstacleDistance < 2 || distance > 20)// || currentX > 3 || currentX < -3 || currentZ < -8)
        {
            reward = -1f;
            done = true;
            return;
        }
        else if(currentX > 3 || currentX < -3 || currentZ < -8)
        {
            reward = -0.01f;
        }
        else
        {
            reward = -0.005f;
            return;
        }
    }

    public override void AgentReset()
    {
        currentX = UnityEngine.Random.Range(-3f, 3f);
        currentZ = -8f;
        goalX = 0f;
        goalZ = 8f;
        obstacleX = UnityEngine.Random.Range(-3f, 3f);
        obstacleZ = UnityEngine.Random.Range(-5f, 5f);
    }
}
