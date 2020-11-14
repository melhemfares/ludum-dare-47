using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuyArtist : MonoBehaviour
{
    public GameObject generalDisplay;
    public void ClickTheButton()
    {
        if (GameManager.Instance.globalMoney >=
            GameManager.Instance.ArtWorkerCost)
        {
            FindObjectOfType<AudioManager>().Play("purchaseSound");

            if (GameManager.Instance.ArtWorkerLevel > 0)
            {
                generalDisplay.GetComponent<Text>().text =
                ("Artist upgraded to Lv " + 
                (GameManager.Instance.ArtWorkerLevel + 1));
            }
            else
            {
                generalDisplay.GetComponent<Text>().text =
                ("Artist has been hired.");
            }

            GameManager.Instance.globalMoney -=
            GameManager.Instance.ArtWorkerCost;

            GameManager.Instance.ArtWorkerLevel++;
            GameManager.Instance.ArtWorkerCost *= 2;
        }
        else
        {
            generalDisplay.GetComponent<Text>().text =
            ("Not enough funds.");
        }
    }
}
