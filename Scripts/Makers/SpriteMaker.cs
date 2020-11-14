using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteMaker : MonoBehaviour
{
    public void ClickTheButton()
    {
        FindObjectOfType<AudioManager>().Play("clickSound");
        SpriteProgress.currentSpriteProgress++;
    }
}
