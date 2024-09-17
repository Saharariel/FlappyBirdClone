using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinGenerator : MonoBehaviour
{
    public GameObject coin;
    public GameObject skin;
    //public float maxTime = 1;
    //private float timer = 0;

    public float respawnTime = 1.0f;
    private Vector2 screenBounds;

    // Start is called before the first frame update
    void Start()
    {
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        StartCoroutine(coinWave());
    }

    // Update is called once per frame
    void Update()
    {
        /*
        if (timer > maxTime)
        {
            Vector3 coinPos = new Vector3(Random.Range(-2f, 2f), Random.Range(-1f, 1f), 0f);
            if ((coinPos - skin.transform.position).magnitude < 3
                    && ((coinPos - UpPipe.transform.position).magnitude < 3))
            {

            }
            else
            {
                Instantiate(coin, coinPos, Quaternion.identity);
                Destroy(coin, 15);
                timer = 0;
            }
        }
        timer += Time.deltaTime;
        */
    }

    private void spawnCoin()
    {
        GameObject a = Instantiate(coin);
        a.transform.position = new Vector2(screenBounds.x * 1.5f, Random.Range(screenBounds.y * 0.4f, -screenBounds.y));

        if ((a.transform.position.y < -0.749))
        {
            Destroy(a);
         }
    }

    IEnumerator coinWave()
    {
        while(true)
        {
            yield return new WaitForSeconds(respawnTime);
            spawnCoin();
        }
    }
}
