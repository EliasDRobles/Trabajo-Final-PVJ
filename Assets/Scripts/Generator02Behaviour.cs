using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Se mueve mientras dispara en tiempos aleatorios
//Podr�a haber sido solo 1 script junto a Generator01Behaviour

public class Generator02Behaviour : MonoBehaviour
{
    [SerializeField]
    private GameObject disparo; //Obtenci�n del disparo o la bala
    private float tiempoAleatorio; //Variable que almacenar� el tiempoAleatorio de disparos
    private float velocidad = 2.5f; //Variable que almacena el valor de la velocidad a la que se mover�n los generadores

    void Start()
    {
        StartCoroutine("GenerarDisparo", tiempoAleatorio); //Iniciamos la Corrutina
    }

    private void Update()
    {
        if (transform.position.z > 38 || transform.position.z < 20) //M�todo If que nos permite controlar el movimiento en Z de los generadores
        {
            velocidad *= -1; //Se cambia el valor de la velocidad
        }
        transform.Translate(0, 0, velocidad * Time.deltaTime); //Se le asigna la nueva velocidad que tendr�n los generadores
    }

    IEnumerator GenerarDisparo() //M�todo que permite usar corrutinas
    {
        float tiempoAleatorio = Random.Range(4, 8); //Establecemos el tiempoAleatorio con un random
        yield return new WaitForSeconds(tiempoAleatorio); //Se espera seg�n el tiempoAleatorio
        Instantiate(disparo, transform.position, transform.rotation); //Se instancia un nuevo disparo con la misma posicion y rotaci�n del generador

        StartCoroutine("GenerarDisparo", tiempoAleatorio); //Se vuelve a llamar al m�todo de la corrutina
    }
}
