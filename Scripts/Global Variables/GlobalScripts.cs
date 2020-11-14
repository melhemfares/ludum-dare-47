using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalScripts : MonoBehaviour
{
    public GameObject scriptsDisplay;
    private int scripts;

    void Update()
    {
        scripts = GameManager.Instance.globalScripts;
        scriptsDisplay.GetComponent<Text>().text = "" + scripts;
    }
}
