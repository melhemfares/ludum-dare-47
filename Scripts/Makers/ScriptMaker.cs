using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptMaker : MonoBehaviour
{
    public void ClickTheButton()
    {
        FindObjectOfType<AudioManager>().Play("clickSound");
        ScriptProgress.currentScriptProgress++;
    }
}
