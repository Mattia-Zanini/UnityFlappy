using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pavimento : MonoBehaviour
{
    Vector2 posizioneIniziale;
    // Start is called before the first frame update
    void Start()
    {
        posizioneIniziale = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (!GameController.gameOver)
        {
            if (transform.position.x < -0.93f)
                transform.position = posizioneIniziale;
            else
                transform.position = new Vector2(transform.position.x - 1.7f * Time.deltaTime, transform.position.y);
        }
    }
}
