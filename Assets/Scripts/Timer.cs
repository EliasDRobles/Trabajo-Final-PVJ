using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    [SerializeField] private TMP_Text timerText;
    [SerializeField, Tooltip("Tiempo Restante en Segundos")] private float timerTime;
    private int minutes, seconds, cents;  

    private void Update()
    {
        timerTime -= Time.deltaTime;

        if (timerTime < 0) timerTime = 0;

        minutes = (int)(timerTime / 60f);
        seconds = (int)(timerTime - minutes * 60f);
        cents = (int)((timerTime - (int)timerTime) * 100f);

        timerText.text = string.Format("{0:00}:{1:00}:{2:00}", minutes, seconds, cents);
        
        if (timerTime == 0)
        {
            //Evento de Tiempo
            Destroy(this);
        }
    }
}
