using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalTracks : MonoBehaviour
{
    public GameObject tracksDisplay;
    private int tracks;

    //Displays number of tracks
    void Update()
    {
        tracks = GameManager.Instance.globalTracks;
        tracksDisplay.GetComponent<Text>().text = "" + tracks;
    }
}
