using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class restart : MonoBehaviour
{
    public void Restart() //funzione che si attiva quando viene premuto il tasto restart
    {
        GameController.gameOver = false;
        SceneManager.LoadScene(0);
    }
}
