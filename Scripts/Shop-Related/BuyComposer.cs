using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuyComposer : MonoBehaviour
{
    public GameObject generalDisplay;
    public void ClickTheButton()
    {
        if (GameManager.Instance.globalMoney >=
            GameManager.Instance.MusicWorkerCost)
        {
            FindObjectOfType<AudioManager>().Play("purchaseSound");

            if (GameManager.Instance.MusicWorkerLevel > 0)
            {
                generalDisplay.GetComponent<Text>().text =
                ("Composer upgraded to Lv " + 
                (GameManager.Instance.MusicWorkerLevel + 1));
            }
            else
            {
                generalDisplay.GetComponent<Text>().text =
                ("Composer has been hired.");
            }

            GameManager.Instance.globalMoney -=
            GameManager.Instance.MusicWorkerCost;

            GameManager.Instance.MusicWorkerLevel++;
            GameManager.Instance.MusicWorkerCost *= 2;
        }
        else
        {
            generalDisplay.GetComponent<Text>().text =
            ("Not enough funds.");
        }
    }
}
