using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HighscoreMenu : MonoBehaviour
{
    

    // Start is called before the first frame update
    void Start()
    {
       GetComponent<TextMeshProUGUI>().text = PlayerPrefs.GetInt("HighScore", 0).ToString();        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
