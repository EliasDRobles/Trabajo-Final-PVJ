using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    [SerializeField] private TMP_Text timerText; // Se crea la referencia para el inspector de texto que usara nuestro Temporizador
    [SerializeField, Tooltip("Tiempo Restante en Segundos")] private float timerTime; // Permite inicializar la cantidad de tiempo quetendra nuestro Juego en el proyecto
    private int minutes, seconds, cents;  // Se instancia las variables int de minutos, segundos y centesimas

    private void Update()
    {
        timerTime -= Time.deltaTime; // Permite restar el temporizador que instanciamos en el Proyecto

        if (timerTime < 0) timerTime = 0; // Si se cumplen las siguientes condiciones del Temporizador
        // Se calcula tanto minutos, segundos y centesimas
        minutes = (int)(timerTime / 60f); 
        seconds = (int)(timerTime - minutes * 60f);
        cents = (int)((timerTime - (int)timerTime) * 100f);

        timerText.text = string.Format("{0:00}:{1:00}:{2:00}", minutes, seconds, cents); // Permite visualizar el textTimer en la pantalla del Jugador
        
        if (timerTime == 0) // Al cumplirse la siguiente condicion, el temporizador se detendra en 00:00
        {
            // Se destruye el temporizador 
            Destroy(this);
        }
    }
}
