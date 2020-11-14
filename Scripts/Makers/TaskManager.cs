using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TaskManager : MonoBehaviour
{
    //If there are no tasks, assign one
    void Update()
    {
        if (GameManager.Instance.taskAssigned == false)
        {
            AssignTask();
            GameManager.Instance.taskAssigned = true;
        }

        if (GameManager.Instance.taskAssignedHard == false)
        {
            AssignTaskHard();
            GameManager.Instance.taskAssignedHard = true;
        }
    }

    //Assigns a task with a random number of each component
    void AssignTask()
    {
        GameManager.Instance.requiredScripts = Random.Range(2, 6);
        GameManager.Instance.requiredSprites = Random.Range(2, 6);
        GameManager.Instance.requiredTracks = Random.Range(2, 6);
    }
    void AssignTaskHard()
    {
        GameManager.Instance.requiredScriptsHard = Random.Range(12, 18);
        GameManager.Instance.requiredSpritesHard = Random.Range(12, 18);
        GameManager.Instance.requiredTracksHard = Random.Range(12, 18);
    }
}
