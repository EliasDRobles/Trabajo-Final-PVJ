using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//La zona en donde se dejan los premios
public class PlaceRewardZone : MonoBehaviour
{
    void Update()
    {

    }
    private void OnCollisionEnter(Collision collision)
    {
        PlayerBehaviour jugador = GameObject.Find("Jugador").GetComponent<PlayerBehaviour>();
        RewardBehaviour premio = GameObject.Find("Premio").GetComponent<RewardBehaviour>();
        if (jugador.TienePremio)
        {
            jugador.Contador++;
            jugador.TienePremio = false;
            Destroy(premio.gameObject);
        }


    }
}
