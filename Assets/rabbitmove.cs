using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class rabbitmove : MonoBehaviour
{
    Rigidbody2D rb;

    public float jumpup;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GetComponent<AudioSource>().Play();
            rb.velocity = Vector2.up * jumpup;
        }
    }

    private void OnCollisionEnter2D(Collision2D other) {

        if(Score.score > Score.Topscore){
            Score.Topscore = Score.score;
        }
        SceneManager.LoadScene("GameOverScene");
    }  
    
}
