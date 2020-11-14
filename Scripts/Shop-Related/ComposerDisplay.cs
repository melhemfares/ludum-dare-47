using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ComposerDisplay : MonoBehaviour
{
    public GameObject composerDisplay;
    private int composerLevel;
    private int composerCost;
 
    void Update()
    {
        composerLevel = GameManager.Instance.MusicWorkerLevel;
        composerCost = GameManager.Instance.MusicWorkerCost;

        composerDisplay.GetComponent<Text>().text =
        ("Composer \nLv " + composerLevel + "\n$" + composerCost);
    }
}
