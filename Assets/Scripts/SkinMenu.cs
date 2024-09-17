using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkinMenu : MonoBehaviour
{
    public GameObject SkinCanvas;
    public GameObject MenuCanvas;
    public GameObject skin;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void showMenu()
    {
        if (SkinCanvas.activeInHierarchy == true)
        {
            SkinCanvas.SetActive(false);
            MenuCanvas.SetActive(true);
            skin.SetActive(true);
        }
        else
        {
            SkinCanvas.SetActive(true);
            MenuCanvas.SetActive(false);
            skin.SetActive(false);
        }
    }
}
