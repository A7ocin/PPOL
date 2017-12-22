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
    private Text text;
    [SerializeField]
    private Transform agent;
    [SerializeField]
    private Transform otherAgent;
    [SerializeField]
    private Transform goal;

    public float originalX, originalZ, originalGoalX, originalGoalZ;
    public float directionX, directionZ;

    int solved, failures;

    public float calculateReward(float distance, float agentsDistance, float originalDistance)
    {
        float expectedReward;
        if (agentsDistance > 2)
        {
            expectedReward = 1 - (distance / originalDistance);
        }
        else if (agentsDistance > 1)
        {
            expectedReward = 1 - (distance / originalDistance) - (2 - agentsDistance);
        }
        else
        {
            expectedReward = -1f;
        }

        return expectedReward;
    }

    public override List<float> CollectState()
    {
        List<float> state = new List<float>();
        state.Add(currentX);
        state.Add(currentZ);
        state.Add(targetX);
        state.Add(targetZ);
        return state;
    }

    public override void AgentStep(float[] action)
    {
        float velocity = 0.0f;

        //if (text != null)
        //{
        //    text.text = string.Format("C:{0}--{1} / T:{2}--{3} [{4}] A:({5})", currentX, currentZ, targetX, targetZ, solved, (int)action[0]);
        //}

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
        float agentsDistance = Mathf.Sqrt(Mathf.Pow((otherAgent.transform.position.x - currentX), 2) + Mathf.Pow((otherAgent.transform.position.z - currentZ), 2));
        float expectedReward = 0f;
        float originalDistance = Mathf.Sqrt(Mathf.Pow((originalX - originalGoalX), 2) + Mathf.Pow((originalZ - originalGoalZ), 2));
        float distanceFromOrigin = Mathf.Sqrt(Mathf.Pow((originalX - currentX), 2) + Mathf.Pow((originalZ - currentZ), 2));

        //expectedReward = calculateReward(distance, agentsDistance, originalDistance);


        if (text != null)
        {
            text.text = string.Format("D:{0} / OD:{1} / AD:{2} [{3};{4}]", distance, originalDistance, agentsDistance, solved, failures);
        }

        //Reached Goal
        if (distance <= 2f)
        {
            solved += 1;
            reward = 2f;
            done = true;
            return;
        }
        //Too far
        else if (distance > originalDistance || agentsDistance < 1)// || agentsDistance < 1 || distanceFromOrigin > originalDistance)
        {
            failures += 1;
            reward = -1f;
            done = true;
            return;
        }
        //Out of social zone
        else if(agentsDistance > 2)
        {
            reward = (1 - (distance / originalDistance)) - CumulativeReward;
            Debug.Log((1 - (distance / originalDistance)) + " - " + CumulativeReward + " = " + reward);
        }
        //Inside social zone
        else
        {
            reward = (1 - (distance / originalDistance)) - CumulativeReward - (2 - agentsDistance);
            Debug.Log((1 - (distance / originalDistance)) + " - " + CumulativeReward + " - (2 - " + agentsDistance + ") = " + reward);
        }
    }

    public override void AgentReset()
    {
        targetX = originalGoalX;// UnityEngine.Random.Range(-5f, 5f);
        targetZ = originalGoalZ; // UnityEngine.Random.Range(-5f, 5f);
        goal.position = new Vector3(originalGoalX, 0, originalGoalZ);
        currentX = UnityEngine.Random.Range(-7.5f, -11f);// originalX;
        currentZ = originalZ;
        //otherAgent.transform.position = new Vector3(Random.Range(-7.5f, -11f), 0, Random.Range(5f, -5f));
    }

}
