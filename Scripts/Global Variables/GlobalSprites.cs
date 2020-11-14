using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalSprites : MonoBehaviour
{
    public GameObject spritesDisplay;
    private int sprites;

    void Update()
    {
        sprites = GameManager.Instance.globalSprites;
        spritesDisplay.GetComponent<Text>().text = "" + sprites;
    }
}
