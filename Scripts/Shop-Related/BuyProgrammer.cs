using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuyProgrammer : MonoBehaviour
{
    public GameObject generalDisplay;
    public void ClickTheButton()
    {
        if (GameManager.Instance.globalMoney >=
            GameManager.Instance.CodeWorkerCost)
        {
            FindObjectOfType<AudioManager>().Play("purchaseSound");

            if (GameManager.Instance.CodeWorkerLevel > 0)
            {
                generalDisplay.GetComponent<Text>().text =
                ("Programmer upgraded to Lv " + 
                (GameManager.Instance.CodeWorkerLevel + 1));
            }
            else
            {
                generalDisplay.GetComponent<Text>().text =
                ("Programmer has been hired.");
            }

            GameManager.Instance.globalMoney -=
            GameManager.Instance.CodeWorkerCost;

            GameManager.Instance.CodeWorkerLevel++;
            GameManager.Instance.CodeWorkerCost *= 2;
        }
        else
        {
            generalDisplay.GetComponent<Text>().text =
            ("Not enough funds.");
        }
    }
}
