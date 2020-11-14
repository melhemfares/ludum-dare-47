using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptProgress : MonoBehaviour
{
    // Finds the bar
    private Transform bar;

    // Max and current progress variables
    public static float maxScriptProgress = 10;
    public static float currentScriptProgress = 0;
    private float progressLeft;

    // Finds the bar named "Bar"
    void Start()
    {
        bar = transform.Find("Bar");
    }

    // Stretches the bar according to current progress
    void Update()
    {
        bar.localScale = new Vector3(currentScriptProgress/maxScriptProgress, 1f);

        progressLeft = maxScriptProgress - currentScriptProgress;

        if (progressLeft <= 0)
        {
            currentScriptProgress = 0;
            GameManager.Instance.globalScripts++;
        }
        else
        {
            currentScriptProgress += GameManager.Instance.CodeWorkerLevel * Time.deltaTime;
        }
    }
}
