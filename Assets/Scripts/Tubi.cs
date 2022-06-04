using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tubi : MonoBehaviour
{
    bool counted = false;
    AudioSource audioP;
    // Start is called before the first frame update
    void Start()
    {
        audioP = GetComponent<AudioSource>();
    }
    // Update is called once per frame
    void Update()
    {
        if (!GameController.gameOver) //se il gioco non è finito
            transform.position = new Vector2(transform.position.x - 1.7f * Time.deltaTime, transform.position.y);
        if (transform.position.x < -4f)
            Destroy(gameObject);
        if (!counted && transform.position.x < -2f)
        {
            audioP.Play();
            counted = true;
            Punti.punteggio++;
        }
    }
}
