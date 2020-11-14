using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrackMaker : MonoBehaviour
{
    public void ClickTheButton()
    {
        FindObjectOfType<AudioManager>().Play("clickSound");
        TrackProgress.currentTrackProgress++;
    }
}
