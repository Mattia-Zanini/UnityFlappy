using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    float spawnTimer;
    float spawnRate = 3f; // ogni 3 secondi spawna un nuovo tubo
    public GameObject tubo;
    public static bool gameOver = false;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (!gameOver)
        {
            spawnTimer += Time.deltaTime; //ad ogni frame sommo a spawnTimer il tempo trascorso dall'ultima frame
            if (spawnTimer >= spawnRate) //se spawnTimer è maggiore o uguale a spawnRate
            {
                spawnTimer = 0; //spawnTimer diventa 0
                Vector2 spawnPos = new Vector2(2f, Random.Range(-0.5f, 4.5f)); //genero una posizione random per il tubo
                Instantiate(tubo, spawnPos, Quaternion.identity); //instanzio un tubo, Quaternion.identity è la rotazione nulla
            }
        }
    }
}
