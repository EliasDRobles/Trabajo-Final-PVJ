using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Se mueve mientras dispara en tiempos aleatorios
//Podría haber sido solo 1 script junto a Generator01Behaviour

public class Generator02Behaviour : MonoBehaviour
{
    [SerializeField]
    private GameObject disparo;
    [SerializeField]
    private float tiempoAleatorio;
    private float velocidad=1f;

    void Start()
    {
        Invoke("GenerarDisparo", tiempoAleatorio);
    }

    private void Update()
    {
        if (transform.position.x > 38 || transform.position.x < 20)
        {
            velocidad *= -1;
        }
        transform.Translate(0, 0, velocidad * Time.deltaTime);
    }

    public void GenerarDisparo()
    {
        Instantiate(disparo, transform.position, transform.rotation);
        tiempoAleatorio = Random.Range(2, 5);
        Invoke("GenerarDisparo", tiempoAleatorio);
    }
}
