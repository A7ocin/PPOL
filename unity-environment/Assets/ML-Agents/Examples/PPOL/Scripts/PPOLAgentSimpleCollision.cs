using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PPOLAgentSimpleCollision : Agent
{

    [SerializeField]
    private float currentX;
    [SerializeField]
    private float currentZ;
    [SerializeField]
    private float targetX;
    [SerializeField]
    private float targetZ;
    [SerializeField]
    private float otherX;
    [SerializeField]
    private float otherZ;
    [SerializeField]
    private Text text;
    [SerializeField]
    private Transform agent;
    [SerializeField]
    private Transform otherAgent;
    [SerializeField]
    private Transform goal;

    public float originalX, originalZ, originalGoalX, originalGoalZ;
    public float directionX, directionZ;

    int solved;


    public override List<float> CollectState()
    {
        List<float> state = new List<float>();
        state.Add(currentX);
        state.Add(currentZ);
        state.Add(targetX);
        state.Add(targetZ);
        state.Add(otherX);
        state.Add(otherZ);
        return state;
    }

    public override void AgentStep(float[] action)
    {
        float velocity = 0.0f;

        if (text != null)
        {
            text.text = string.Format("C:{0}--{1} / T:{2}--{3} [{4}] A:({5})", currentX, currentZ, targetX, targetZ, solved, (int)action[0]);
        }

        switch ((int)action[0])
        {
            case 0:
                currentX = Mathf.SmoothDamp(currentX, currentX - directionX * 5.0f, ref velocity, 0.4f);
                //currentX -= 0.01f;
                break;
            case 1:
                currentX = Mathf.SmoothDamp(currentX, currentX + directionX * 5.0f, ref velocity, 0.4f);
                //currentX += 0.01f;
                break;
            case 2:
                currentZ = Mathf.SmoothDamp(currentZ, currentZ - directionZ * 5.0f, ref velocity, 0.4f);
                //currentZ -= 0.01f;
                break;
            case 3:
                currentZ = Mathf.SmoothDamp(currentZ, currentZ + directionZ * 5.0f, ref velocity, 0.4f);
                //currentZ += 0.01f;
                break;
            default:
                return;
        }

        //if (currentX < -1.2 || currentX > 1.2 || currentZ < -1.2 || currentZ > 1.2)
        //{
        //    reward = -1f;
        //    done = true;
        //    return;
        //}

        agent.position = new Vector3(currentX, -0.5f, currentZ);
        agent.LookAt(goal.transform);

        float distance = Mathf.Sqrt(Mathf.Pow((targetX - currentX), 2) + Mathf.Pow((targetZ - currentZ), 2));
        float agentsDistance = Mathf.Sqrt(Mathf.Pow((otherX - currentX), 2) + Mathf.Pow((otherZ - currentZ), 2));
        if (distance <= 2f)
        {
            solved += 1;
            reward = 1;
            done = true;
            return;
        }
        else if (distance > 20)
        {
            reward = -1f;
            done = true;
            return;
        }
        else
        {
            if (agentsDistance > 5) {
                reward = 0 - distance - CumulativeReward - 1;
            }
            else
            {
                reward = -1f; // 0 - 10*(1 - agentsDistance) - distance - CumulativeReward - 1;
            }
            return;
        }
    }

    public override void AgentReset()
    {
        targetX = originalGoalX;// UnityEngine.Random.Range(-5f, 5f);
        targetZ = originalGoalZ; // UnityEngine.Random.Range(-5f, 5f);
        goal.position = new Vector3(originalGoalX, 0, originalGoalZ);
        currentX = originalX;
        currentZ = originalZ;
    }

}
