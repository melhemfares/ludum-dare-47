using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LeaveShop : MonoBehaviour
{
    public void ClickTheButton()
    {
        FindObjectOfType<AudioManager>().Play("clickSound");
        
        SceneManager.LoadScene 
        (sceneBuildIndex: 1);
    }
}
