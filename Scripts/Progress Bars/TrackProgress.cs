using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrackProgress : MonoBehaviour
{
    // Finds the bar
    private Transform bar;

    // Max and current time variables
    public static float maxTrackProgress = 10;
    public static float currentTrackProgress;
    private float progressLeft;

    // Finds the bar named "Bar"
    void Start()
    {
        bar = transform.Find("Bar");
    }

    // Stretches the bar according to current time
    void Update()
    {
        bar.localScale = new Vector3(currentTrackProgress/maxTrackProgress, 1f);

        progressLeft = maxTrackProgress - currentTrackProgress;

        if (progressLeft <= 0)
        {
            currentTrackProgress = 0;
            GameManager.Instance.globalTracks++;
        }
        else
        {
            currentTrackProgress += GameManager.Instance.MusicWorkerLevel * Time.deltaTime;
        }
    }
}
