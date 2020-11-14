using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteProgress : MonoBehaviour
{
    // Finds the bar
    private Transform bar;

    // Max and current time variables
    public static float maxSpriteProgress = 10;
    public static float currentSpriteProgress;
    private float progressLeft;

    // Finds the bar named "Bar"
    void Start()
    {
        bar = transform.Find("Bar");
    }

    // Stretches the bar according to current time
    void Update()
    {
        bar.localScale = new Vector3(currentSpriteProgress/maxSpriteProgress, 1f);

        progressLeft = maxSpriteProgress - currentSpriteProgress;

        if (progressLeft <= 0)
        {
            currentSpriteProgress = 0;
            GameManager.Instance.globalSprites++;
        }
        else
        {
            currentSpriteProgress += GameManager.Instance.ArtWorkerLevel * Time.deltaTime;
        }
    }
}
