using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Script encargada del movimiento, el giro o si son destruidas

public class PlataformBehaviour : MonoBehaviour
{
    [SerializeField]
    private bool seMueve;
    [SerializeField]
    private bool esAscensor;
    [SerializeField]
    private bool estaGirando;
    [SerializeField]
    private float velocidad = 2f;
    [SerializeField]
    private float velocidadRotacion;
    
    //Aqui se decide que hacen segun el tipo de plataforma sea
    void Update()
    {
        if(estaGirando)
        {
            transform.Rotate(0, velocidadRotacion, 0);
        }
        if (seMueve)
        {
            transform.Translate(velocidad * Time.deltaTime, 0, 0);
        }
        if (esAscensor) {
            transform.Translate(0, velocidad * Time.deltaTime, 0);
        }
    }

    //Se destruyen al entrar con un objeto con TAG Destructor
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Destructor"))
        {
            Destroy(transform.gameObject);
        }        
    }
}
