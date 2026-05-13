using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TimerUI : MonoBehaviour
{
    public TextMeshProUGUI txtTiempo;
    float tiempoTranscurrido = 0f;

    void Update()
    {
        if(GameOver.gameOver == false)
        {
            tiempoTranscurrido += Time.deltaTime;
            int segundos = Mathf.FloorToInt(tiempoTranscurrido) + 1;
            txtTiempo.text = segundos.ToString("00");
        }
    }
}