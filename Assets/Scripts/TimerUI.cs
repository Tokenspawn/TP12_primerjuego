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
        tiempoTranscurrido += Time.deltaTime;
        txtTiempo.text = tiempoTranscurrido.ToString("F2");
    }
}