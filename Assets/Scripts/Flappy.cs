using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flappy : MonoBehaviour
{
    Rigidbody2D rb;
    public GameObject gameover;
    public GameObject restart;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && !GameController.gameOver)
            rb.velocity = new Vector2(0f, 4.3f);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameController.gameOver = true;
        gameover.SetActive(true); //se il player collide con un tubo, mostra il gameover
        restart.SetActive(true); //se il player collide con un tubo, mostra il restart
    }
}
