using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeBar : MonoBehaviour
{
    // Finds the bar
    private Transform bar;

    // Max and current time variables
    public float maxTime;
    public float currentTime;

    // Finds the bar named "Bar"
    void Start()
    {
        bar = transform.Find("Bar");
        maxTime = 5;
        currentTime = 3;
    }

    // Stretches the bar according to current time
    void Update()
    {
        bar.localScale = new Vector3(currentTime/maxTime, 1f);
    }
}
