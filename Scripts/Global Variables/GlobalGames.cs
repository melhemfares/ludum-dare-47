using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalGames : MonoBehaviour
{
    public GameObject gamesDisplay;
    private int games;

    void Update()
    {
        games = GameManager.Instance.globalGames;
        gamesDisplay.GetComponent<Text>().text = "" + games;
    }
}
