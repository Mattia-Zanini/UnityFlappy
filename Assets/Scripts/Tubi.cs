using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tubi : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (!GameController.gameOver) //se il gioco non è finito
        {
            transform.position = new Vector2(transform.position.x - 1.7f * Time.deltaTime, transform.position.y);
            if (transform.position.x < -4f)
                Destroy(gameObject);
        }
    }
}
