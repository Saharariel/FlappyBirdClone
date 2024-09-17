using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;

public class StartGame : MonoBehaviour
{

    public TextMeshProUGUI highScore;
    public Button startButton;
    AsyncOperation asop;

    void Start()
    {
        if (SceneManager.GetActiveScene().buildIndex == 0)
        {
            asop = SceneManager.LoadSceneAsync(1);
            asop.allowSceneActivation = false;
        }
    }

    public void startGame()
    {
        asop.allowSceneActivation = true;
    }
    public void secretMode()
    {
        SceneManager.LoadScene(2);
    }

    public void TextChanged(string text)
    {
        if (text == "haver")
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene(2);
        }
    }

    public void ResetHighScore()
    {
        
        PlayerPrefs.DeleteKey("HighScore");
        highScore.text = "0";
        PlayerPrefs.DeleteAll();

       // PlayerPrefs.SetInt("totalCoins", 1000);
       // PlayerPrefs.SetInt("HighScore", 90);
       PlayerPrefs.SetString("unlocked:secretskin", "true");
    }
}
