using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicMenu : MonoBehaviour
{
    public GameObject MusicCanvas;
    public GameObject MenuCanvas;
    public AudioSource music;
    public GameObject skin;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void showMenuMusic()
    {
        if (MusicCanvas.activeInHierarchy == true)
        {
            music.Stop();
            MusicCanvas.SetActive(false);
            MenuCanvas.SetActive(true);
            skin.SetActive(true);
        }
        else
        {
            MusicCanvas.SetActive(true);
            MenuCanvas.SetActive(false);
            skin.SetActive(false);
        }
    }
}
