using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProgrammerDisplay : MonoBehaviour
{
    public GameObject programmerDisplay;
    private int programmerLevel;
    private int programmerCost;
 
    void Update()
    {
        programmerLevel = GameManager.Instance.CodeWorkerLevel;
        programmerCost = GameManager.Instance.CodeWorkerCost;

        programmerDisplay.GetComponent<Text>().text =
        ("Programmer \nLv " + programmerLevel + "\n$" + programmerCost);
    }
}
