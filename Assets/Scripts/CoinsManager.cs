using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using TMPro;
using UnityEngine;

public class CoinsManager : MonoBehaviour
{
    public int coinsToGive;
    public AudioClip[] haverArray;
    public AudioSource haver;
    //public TextMeshProUGUI totalCoins;

    // Start is called before the first frame update
    void Start()
    {
        
        haver.clip = null;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.left * 0.5f * Time.deltaTime;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //int iCoins = int.Parse(GetComponent<updateCoins>().coinsCounter.text);

        if (collision.gameObject.name == "Skin")
        {
            if (PlayerPrefs.GetString("skin") == "secretskin")
            {
                haver.clip = haverArray[Random.Range(0, haverArray.Length)];
                haver.Play();
            }
            //totalCoins.text = (iCoins + 1).ToString();
            //GetComponent<updateCoins>().addCoin();

            if (PlayerPrefs.GetString("skin") == "secretskin")
            {
                CoinsScript.coinAmout += 2;
            }
            else
            {
                CoinsScript.coinAmout += 1;
            }
            //gameObject.SetActive(false);

            transform.position = Vector3.one * 9999f; // move the game object off screen while it finishes it's sound, then destroy it
            if (PlayerPrefs.GetString("skin") == "secretskin")
            {
                Destroy(gameObject, haver.clip.length);
            }
            // FindObjectOfType<CoinGenerator>().spawnCoin();
        }
    }
}
