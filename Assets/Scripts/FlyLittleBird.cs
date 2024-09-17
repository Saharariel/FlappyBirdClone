using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FlyLittleBird : MonoBehaviour
{
    public GameManager gameManagerSecret;
    public float velocity = 1;
    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (SceneManager.GetActiveScene().buildIndex == 1)
        {
            if (Input.GetMouseButtonDown(0))
            {
                //Jump
                rb.velocity = Vector2.up * velocity;
            }
        } else if (SceneManager.GetActiveScene().buildIndex == 2)
        {
            if (Input.GetMouseButtonDown(0))
            {
                //Jump
                rb.velocity = Vector2.up * (velocity + 0.2f);
            }
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "PipeUp" || collision.gameObject.name == "PipeDown" || collision.gameObject.name == "Ground")
        {
            gameManagerSecret.GameOver();
        }
    }
}
