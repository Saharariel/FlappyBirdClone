using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CoinsScript : MonoBehaviour
{

    TextMeshProUGUI text;
    public static int coinAmout;
    // Start is called before the first frame update
    void Start()
    {
        coinAmout = 0;
        text = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        text.text = coinAmout.ToString();
    }
}
