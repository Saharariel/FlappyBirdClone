using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class ClickCountDetector : MonoBehaviour
{

    public GameObject password;
    public GameObject reset;

    public void onSecretClick()
    {
        if(password.activeInHierarchy == false)
        {
            password.SetActive(true);
        } else
        {
            password.SetActive(false);
        }
    }
    public void onResetClick()
    {
        if (reset.activeInHierarchy == false)
        {
            reset.SetActive(true);
        }
        else
        {
            reset.SetActive(false);
        }
    }

}
