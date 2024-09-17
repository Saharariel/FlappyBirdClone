using DanielLochner.Assets.SimpleScrollSnap;
using TMPro;
using UnityEngine;
using Image = UnityEngine.UI.Image;

public class MusicManager : MonoBehaviour
{
    public MusicMenu sm;
    public SimpleScrollSnap scroll;
    public AudioSource audioSource;
    public TextMeshProUGUI totalCoins;
    public TextMeshProUGUI totalCoinsInMenu;

    //songs
    public AudioClip nonoSquare;
    public AudioClip guntharSong;
    public AudioClip allStar;
    public AudioClip mondial;

    //Gunthar
    public Image guntharPic;
    public GameObject guntharLocked;
    public GameObject guntharCanBuy;

    //allStar
    public Image allstarPic;
    public GameObject allstarLocked;
    public GameObject allstarCanBuy;

    //mondial
    public Image mondialPic;
    public GameObject mondialLocked;
    public GameObject mondialCanBuy;

    // Start is called before the first frame update
    void Start()
    {
        //gunthar
        if (PlayerPrefs.GetString("unlockedsong:gunthar") == "true")
        {
            guntharPic.color = new Color(255, 255, 255);
            guntharLocked.SetActive(false);
        }
        //allstars
        if (PlayerPrefs.GetString("unlockedsong:allstar") == "true")
        {
            allstarPic.color = new Color(255, 255, 255);
            allstarLocked.SetActive(false);
        }

        //mondial
        if (PlayerPrefs.GetString("unlockedsong:mondial") == "true")
        {
            mondialPic.color = new Color(255, 255, 255);
            mondialLocked.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {

        //coins view
        totalCoinsInMenu.text = PlayerPrefs.GetInt("totalCoins").ToString();

        //gunthar
        if (PlayerPrefs.GetInt("totalCoins", 0) >= 20)
        {
            guntharCanBuy.SetActive(true);
        }
        else
        {
            guntharCanBuy.SetActive(false);
        }

        //allstar
        if (PlayerPrefs.GetInt("totalCoins", 0) >= 40)
        {
            allstarCanBuy.SetActive(true);
        }
        else
        {
            allstarCanBuy.SetActive(false);
        }

        //mondial
        if (PlayerPrefs.GetInt("totalCoins", 0) >= 60)
        {
            mondialCanBuy.SetActive(true);
        }
        else
        {
            mondialCanBuy.SetActive(false);
        }
    }

    public void checkMusic()
    {
        if (scroll.CurrentPanel == 1) //nonoSquare
        {
            audioSource.clip = nonoSquare;
            audioSource.time = 13f;
            audioSource.volume = 0.5f;
            audioSource.Play();
        }
        if (scroll.CurrentPanel == 2) //Gunthar
        {
            audioSource.clip = guntharSong;
            audioSource.time = 7f;
            audioSource.volume = 0.5f;
            audioSource.Play();
        }
        if (scroll.CurrentPanel == 3) //Allstar
        {
            audioSource.clip = allStar;
            audioSource.time = 0;
            audioSource.volume = 0.5f;
            audioSource.Play();
        }
        if (scroll.CurrentPanel == 4) //Mondial
        {
            audioSource.clip = mondial;
            audioSource.time = 0;
            audioSource.volume = 0.5f;
            audioSource.Play();
        }
    }

    public void ChooseNonoSquare()
    {
        PlayerPrefs.SetString("music", "nonosquare");
        sm.showMenuMusic();
    }
    public void ChooseGunthar()
    {
        if (PlayerPrefs.GetString("unlockedsong:gunthar", "false") == "true")
        {
            PlayerPrefs.SetString("music", "gunthar");
            //audioSource.Stop();
            sm.showMenuMusic();
        }
    }
    public void ChooseAllstar()
    {
        if (PlayerPrefs.GetString("unlockedsong:allstar", "false") == "true")
        {
            PlayerPrefs.SetString("music", "allstar");
            //audioSource.Stop();
            sm.showMenuMusic();
        }
    }
    public void ChooseMonidal()
    {
        if (PlayerPrefs.GetString("unlockedsong:mondial", "false") == "true")
        {
            PlayerPrefs.SetString("music", "mondial");
            //audioSource.Stop();
            sm.showMenuMusic();
        }
    }

    public void buyGunthar()
    {
        if (PlayerPrefs.GetInt("totalCoins", 0) >= 20)
        {
            PlayerPrefs.SetInt("totalCoins", PlayerPrefs.GetInt("totalCoins", 0) - 20);
            PlayerPrefs.SetString("unlockedsong:gunthar", "true");
            guntharPic.color = new Color(255, 255, 255);
            guntharLocked.SetActive(false);
            guntharCanBuy.SetActive(false);
            totalCoins.text = PlayerPrefs.GetInt("totalCoins", 0).ToString();
        }
    }
    public void buyAllStar()
    {
        if (PlayerPrefs.GetInt("totalCoins", 0) >= 40)
        {
            PlayerPrefs.SetInt("totalCoins", PlayerPrefs.GetInt("totalCoins", 0) - 40);
            PlayerPrefs.SetString("unlockedsong:allstar", "true");
            allstarPic.color = new Color(255, 255, 255);
            allstarLocked.SetActive(false);
            allstarCanBuy.SetActive(false);
            totalCoins.text = PlayerPrefs.GetInt("totalCoins", 0).ToString();
        }
    }
    public void buyMondial()
    {
        if (PlayerPrefs.GetInt("totalCoins", 0) >= 60)
        {
            PlayerPrefs.SetInt("totalCoins", PlayerPrefs.GetInt("totalCoins", 0) - 60);
            PlayerPrefs.SetString("unlockedsong:mondial", "true");
            mondialPic.color = new Color(255, 255, 255);
            mondialLocked.SetActive(false);
            mondialCanBuy.SetActive(false);
            totalCoins.text = PlayerPrefs.GetInt("totalCoins", 0).ToString();
        }
    }
}
