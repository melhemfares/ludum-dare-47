using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EllipsisVisibilty : MonoBehaviour
{
    public GameObject ellipsis;
    void Update()
    {
        if (GameManager.Instance.taskInProgress == true
            || GameManager.Instance.taskInProgressHard == true)
        {
            ellipsis.GetComponent<Renderer>().enabled = true;
        }
        else
        {
            ellipsis.GetComponent<Renderer>().enabled = false;
        }
    }
}
