using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flappy : MonoBehaviour
{
    Rigidbody2D rb;
    public GameObject gameover;
    public GameObject restart;
    public AudioClip[] audioflappy;
    AudioSource audiosource;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        audiosource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && !GameController.gameOver)
        {
            audiosource.PlayOneShot(audioflappy[0]); //volo
            rb.velocity = new Vector2(0f, 4.3f);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        audiosource.PlayOneShot(audioflappy[1]); //schianto
        GameController.gameOver = true;
        gameover.SetActive(true); //se il player collide con un tubo, mostra il gameover
        restart.SetActive(true); //se il player collide con un tubo, mostra il restart
    }
}
