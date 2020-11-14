using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TaskDisplay2 : MonoBehaviour
{
    public GameObject taskDisplay;
    private int sprites;
    private int scripts;
    private int tracks;

    public static int totalParts;

    void Update()
    {
        sprites = GameManager.Instance.requiredSpritesHard;
        scripts = GameManager.Instance.requiredScriptsHard;
        tracks = GameManager.Instance.requiredTracksHard;

        totalParts = sprites + scripts + tracks;

        taskDisplay.GetComponent<Text>().text =
        "Large Game\nRequired: \n" + sprites + " sprites, " + scripts
        + " scripts, " + tracks + " tracks." ;
    }
}
