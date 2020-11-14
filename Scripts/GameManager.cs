using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }

    //All of the global variables
    public int globalTracks;
    public int globalScripts;
    public int globalSprites;
    public int globalGames;
    public int globalMoney;

    //Worker levels
    public int MusicWorkerLevel = 0;
    public int ArtWorkerLevel = 0;
    public int CodeWorkerLevel = 0;

    //Worker costs
    public int MusicWorkerCost;
    public int ArtWorkerCost;
    public int CodeWorkerCost;

    //Tasks
    public bool taskAccepted = false;
    public bool taskInProgress = false;
    public bool taskAssigned = false;
    public bool taskAcceptedHard = false;
    public bool taskInProgressHard = false;
    public bool taskAssignedHard = false;

    //Task requirements
    public int requiredScripts = 1;
    public int requiredSprites = 1;
    public int requiredTracks = 1;
    public int requiredScriptsHard = 1;
    public int requiredSpritesHard = 1;
    public int requiredTracksHard = 1;

    //My singleton (stores all variables listed in every scene)
    private void Awake()
    {
        FindObjectOfType<AudioManager>().Play("backgroundTheme");
        
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
