using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class SecretMode : MonoBehaviour
{
    int tap;
    public void OnPointerClick(PointerEventData eventData)
    {
        tap = eventData.clickCount;

        if (tap == 5)
        {
            SceneManager.LoadScene(2);
        }

    }
}
