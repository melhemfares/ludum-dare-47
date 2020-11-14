using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ArtistDisplay : MonoBehaviour
{
    public GameObject artistDisplay;
    private int artistLevel;
    private int artistCost;
 
    void Update()
    {
        artistLevel = GameManager.Instance.ArtWorkerLevel;
        artistCost = GameManager.Instance.ArtWorkerCost;

        artistDisplay.GetComponent<Text>().text =
        ("Artist \nLv " + artistLevel + "\n$" + artistCost);
    }
}
