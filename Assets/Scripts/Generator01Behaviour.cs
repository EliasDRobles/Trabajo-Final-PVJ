using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Se mueve mientras dispara en tiempos aleatorios
//Podría haber sido solo 1 script junto a Generator02Behaviour

public class Generator01Behaviour : MonoBehaviour
{
    [SerializeField]
    private GameObject plataformaDesplazable;
    [SerializeField]
    private float tiempoInicial;
    [SerializeField]
    private float intervalo;

    void Start()
    {
        InvokeRepeating("GenerarPlataforma", tiempoInicial, intervalo);
    }

    public void GenerarPlataforma()
    {
        Instantiate(plataformaDesplazable, transform.position, transform.rotation);
    }
}
