using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TaskDisplay : MonoBehaviour
{
    public GameObject taskDisplay;
    private int sprites;
    private int scripts;
    private int tracks;

    public static int totalParts;

    void Update()
    {
        sprites = GameManager.Instance.requiredSprites;
        scripts = GameManager.Instance.requiredScripts;
        tracks = GameManager.Instance.requiredTracks;

        if (GameManager.Instance.taskInProgress == true)
        {
            totalParts = sprites + scripts + tracks;
        }
        else if (GameManager.Instance.taskInProgressHard == true)
        {
            totalParts = TaskDisplay2.totalParts;
        }
        else
        {
            totalParts = 0;
        }
        
        taskDisplay.GetComponent<Text>().text =
        "Small Game\nRequired: \n" + sprites + " sprites, " + scripts
        + " scripts, " + tracks + " tracks." ;
    }
}
