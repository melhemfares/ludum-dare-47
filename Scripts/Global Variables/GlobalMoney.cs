using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalMoney : MonoBehaviour
{
    public GameObject moneyDisplay;
    private int money;

    void Update()
    {
        money = GameManager.Instance.globalMoney;
        moneyDisplay.GetComponent<Text>().text = "" + money;
    }
}
