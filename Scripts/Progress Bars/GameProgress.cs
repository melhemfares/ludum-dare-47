using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameProgress : MonoBehaviour
{
    // Finds the bar
    private Transform bar;
    public GameObject ratingDisplay;

    // Max and current progress variables
    public static float maxGameProgress = 20;
    public static float currentGameProgress = 0;
    private float progressLeft;

    public static float gameRating;
    public static int moneyEarned;

    // Finds the bar named "Bar"
    void Start()
    {
        bar = transform.Find("Bar");
    }

    // Stretches the bar according to current progress
    void Update()
    {
        bar.localScale = new Vector3(currentGameProgress/maxGameProgress, 1f);

        progressLeft = maxGameProgress - currentGameProgress;

        if (progressLeft <= 0)
        {
            if (GameManager.Instance.taskInProgress == true)
            {
                GameManager.Instance.taskAssigned = false;
            }
            else if (GameManager.Instance.taskInProgressHard == true)
            {
                GameManager.Instance.taskAssignedHard = false;
            }

            currentGameProgress = 0;
            GameManager.Instance.globalGames++;
            GameManager.Instance.taskInProgress = false;
            GameManager.Instance.taskInProgressHard = false;

            Reward();
        }
    }
    void Reward()
    {
        gameRating = Random.Range(0f, 10f);

        if (gameRating < 1)
        {
            moneyEarned = TaskDisplay.totalParts * Random.Range(2, 5);
            ratingDisplay.GetComponent<Text>().text =
            ("Your game did poorly... " + "+$" + moneyEarned);
        }
        else if (gameRating > 1 && gameRating < 9)
        {
            moneyEarned = TaskDisplay.totalParts * Random.Range(8, 12);
            ratingDisplay.GetComponent<Text>().text =
            ("Your game did well. " + "+$" + moneyEarned);
        }
        else
        {
            moneyEarned = TaskDisplay.totalParts * Random.Range(20, 30);
            ratingDisplay.GetComponent<Text>().text =
            ("Your game did amazing! " + "+$" + moneyEarned);
        }

        GameManager.Instance.globalMoney += moneyEarned;
    }
}
