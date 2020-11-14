using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AcceptTask : MonoBehaviour
{
    public static bool taskMeetsRequirements = false;

    public GameObject generalDisplay;

    void Update()
    {
        if (GameManager.Instance.globalScripts >= GameManager.Instance.requiredScripts
        && GameManager.Instance.globalSprites >= GameManager.Instance.requiredSprites
        && GameManager.Instance.globalTracks >= GameManager.Instance.requiredTracks)
        {
            taskMeetsRequirements = true;
        }
    }
    public void ClickTheButton()
    {
        FindObjectOfType<AudioManager>().Play("clickSound");

        if (GameManager.Instance.taskInProgress == false
            && GameManager.Instance.taskInProgressHard == false)
        {
            if (taskMeetsRequirements == true)
            {
                GameManager.Instance.globalScripts -= GameManager.Instance.requiredScripts;
                GameManager.Instance.globalSprites -= GameManager.Instance.requiredSprites;
                GameManager.Instance.globalTracks -= GameManager.Instance.requiredTracks;

                taskMeetsRequirements = false;
                GameManager.Instance.taskInProgress = true;

                generalDisplay.GetComponent<Text>().text =
                ("Task accepted. Your small game is ready to be built.");
            }
            else
            {
                generalDisplay.GetComponent<Text>().text =
                ("The task requirements have not been met.");
            }
        }
        else
        {
            generalDisplay.GetComponent<Text>().text =
            ("There is already a task in progress.");
        }
    }
}
