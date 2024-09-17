using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class secretSkin : MonoBehaviour
{

    public GameObject secretText;
    public float waitTime = 3;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Skin")
        {
            if (PlayerPrefs.GetString("unlocked:secretskin", "false") == "false")
            {
                PlayerPrefs.SetString("unlocked:secretskin", "true");
                StartCoroutine(coloredText());
            }
        }
    }

    IEnumerator coloredText()
    {
        secretText.SetActive(true);
        yield return new WaitForSeconds(waitTime);
        secretText.SetActive(false);
    }
}
