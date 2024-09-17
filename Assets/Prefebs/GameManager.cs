using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public GameObject gameOverCanvas;
    public GameObject scoreCanvas;
    public AudioSource music;
    public GameObject secretText;

    AsyncOperation asop;
    //AsyncOperation asopMain;
    public TextMeshProUGUI Highscore;
    public TextMeshProUGUI totalCoins;
    public GameObject HighscoreCanvas;
    public GameObject secretEliav;

    //skins
    public SpriteRenderer skin;
    public Sprite Eliav;
    public Sprite Kai;
    public Sprite Bechor;
    public Sprite Maman;
    public Sprite Kobi;
    public Sprite yuvgal;
    public Sprite gunthar;
    public Sprite kook;
    public Sprite meny;
    public Sprite beny;
    public Sprite hendler;
    public Sprite mosti;
    public Sprite yali;
    public Sprite secretSkin;

    //music
    public AudioClip nonoSquare;
    public AudioClip guntharClip;
    public AudioClip allstarClip;
    public AudioClip mondialClip;

    // Start is called before the first frame update
    private void Start()
    {
        if (SceneManager.GetActiveScene().buildIndex == 1)
        {
            asop = SceneManager.LoadSceneAsync(0);
            asop.allowSceneActivation = false;
        }


        //
        Time.timeScale = 1;
        scoreCanvas.SetActive(true);

        if(PlayerPrefs.GetString("skin") == "eliav")
        {
            skin.sprite = Eliav;
        }
        if (PlayerPrefs.GetString("skin") == "kai")
        {
            skin.sprite = Kai;
        }
        if (PlayerPrefs.GetString("skin") == "bechor")
        {
            skin.sprite = Bechor;
        }
        if (PlayerPrefs.GetString("skin") == "maman")
        {
            skin.sprite = Maman;
        }
        if (PlayerPrefs.GetString("skin") == "kobi")
        {
            skin.sprite = Kobi;
        }
        if (PlayerPrefs.GetString("skin") == "yuvgal")
        {
            skin.sprite = yuvgal;
        }
        /*
        if (PlayerPrefs.GetString("skin") == "gunthar")
        {
            skin.sprite = gunthar;
        }
        */
        if (PlayerPrefs.GetString("skin") == "kook")
        {
            skin.sprite = kook;
        }
        if (PlayerPrefs.GetString("skin") == "meny")
        {
            skin.sprite = meny;
        }
        if (PlayerPrefs.GetString("skin") == "beny")
        {
            skin.sprite = beny;
        }
        if (PlayerPrefs.GetString("skin") == "hendler")
        {
            skin.sprite = hendler;
        }
        if (PlayerPrefs.GetString("skin") == "mosti")
        {
            skin.sprite = mosti;
        }
        if (PlayerPrefs.GetString("skin") == "yali")
        {
            skin.sprite = yali;
        }
        if (PlayerPrefs.GetString("skin") == "secretskin")
        {
            skin.sprite = secretSkin;
        }

        //Music

        //nonosquare
        if(PlayerPrefs.GetString("music","nonosquare") == "nonosquare")
        {
            music.clip = nonoSquare;
            music.Play();
        }
        //Gunthar
        if (PlayerPrefs.GetString("music", "nonosquare") == "gunthar")
        {
            music.clip = guntharClip;
            music.volume = 0.8f;
            music.Play();
        }
        //allStar
        if (PlayerPrefs.GetString("music", "nonosquare") == "allstar")
        {
            music.clip = allstarClip;
            music.volume = 0.8f;
            music.Play();
        }

        //mondiaal
        if (PlayerPrefs.GetString("music", "nonosquare") == "mondial")
        {
            music.clip = mondialClip;
            music.volume = 0.8f;
            music.Play();
        }


        //

        if (PlayerPrefs.GetString("skin") == "gunthar")
        {
            skin.sprite = gunthar;
            music.clip = guntharClip;
            music.volume = 0.8f;
            music.Play();
        }

    }

    private void Update()
    {
        if(Score.score == 69)
        {
            StartCoroutine(spawnSecretEliav());
        }
    }

    IEnumerator spawnSecretEliav()
    {
        secretEliav.SetActive(true);
        yield return new WaitForSeconds(3.0f);
        secretEliav.SetActive(false);
    }

    public void GameOver()
    {
        
        if (Score.score > PlayerPrefs.GetInt("HighScore", 0))
        {
            PlayerPrefs.SetInt("HighScore", Score.score);
            Highscore.text = Score.score.ToString();
            HighscoreCanvas.SetActive(true);
        }
        music.gameObject.SetActive(false);
        secretText.SetActive(false);
        gameOverCanvas.SetActive(true);
        Time.timeScale = 0;

        //AddCoins
        PlayerPrefs.SetInt("totalCoins", PlayerPrefs.GetInt("totalCoins", 0) + CoinsScript.coinAmout);
        //Debug.Log(PlayerPrefs.GetInt("totalCoins"));
        totalCoins.text = PlayerPrefs.GetInt("totalCoins", 0).ToString();


        //Skins unlocks
        if (PlayerPrefs.GetInt("HighScore") >= 10) PlayerPrefs.SetString("unlocked:kai", "true");
        if (PlayerPrefs.GetInt("HighScore") >= 40) PlayerPrefs.SetString("unlocked:yuvgal", "true");
        if (PlayerPrefs.GetInt("HighScore") >= 50) PlayerPrefs.SetString("unlocked:kook", "true");

    }

    public void Replay()
    {
        SceneManager.LoadScene(1);
    }

    public void ReplaySecret()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(2);
    }
    public void backMainMenu()
    {
        Time.timeScale = 1;
        asop.allowSceneActivation = true;
    }
}
