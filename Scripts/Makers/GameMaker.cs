using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMaker : MonoBehaviour
{
    public void ClickTheButton()
    {
        FindObjectOfType<AudioManager>().Play("clickSound");
        
        if (GameManager.Instance.taskInProgress == true)
        {
            GameProgress.currentGameProgress += 2;
        }
        else if (GameManager.Instance.taskInProgressHard == true)
        {
            GameProgress.currentGameProgress ++;
        }
        else
        {
            return;
        }
    }
}
