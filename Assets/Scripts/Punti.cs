using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Punti : MonoBehaviour
{
    public static int punteggio;
    // Start is called before the first frame update
    void Start()
    {
        punteggio = 0;
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<TextMeshProUGUI>().text = punteggio.ToString();
    }
}
