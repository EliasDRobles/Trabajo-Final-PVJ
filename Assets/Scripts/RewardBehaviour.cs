using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//Comportamiento del premio
public class RewardBehaviour : MonoBehaviour
{
    private float giro = 50f;
    void Update()
    {
        transform.Rotate(0, giro * Time.deltaTime, 0);
    }

    private void OnTriggerEnter(Collider other)
    {
        PlayerBehaviour jugador = GameObject.Find("Jugador").GetComponent<PlayerBehaviour>();
        if (other.CompareTag("Player") && jugador.TienePremio == false)
        {
            transform.parent = jugador.transform;
            jugador.TienePremio = true;
            giro = 0f;
        }
    }
}
