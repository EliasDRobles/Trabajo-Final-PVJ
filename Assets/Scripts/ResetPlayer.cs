using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Se encarga de devolver al jugador al inicio del nivel que se encuentre
public class ResetPlayer : MonoBehaviour
{

    [SerializeField]
    private int nivel;
    public float daño = 1.0f;

    private void OnTriggerEnter(Collider other)
    {
        PlayerMov player = GameObject.Find("Perrito").GetComponent<PlayerMov>();
        RewardBehaviour reward = GameObject.Find("Premio").GetComponent<RewardBehaviour>();
        switch (nivel)
        {
            case 1:
                if (other.CompareTag("Player"))
                {
                    player.transform.position = new Vector3(-50, 16, 15);
                    player.ActualVida = player.ActualVida - daño;
                }


                if (other.CompareTag("Premio"))
                {
                    reward.transform.position = new Vector3((float)-55.61, (float)15.5, (float)44.3);
                }
                break;
            case 2:
                if (other.CompareTag("Player"))
                {
                    player.transform.position = new Vector3(0, 17, 15);
                    player.ActualVida = player.ActualVida - daño;
                }
                if (other.CompareTag("Premio"))
                {
                    reward.transform.position = new Vector3(9, (float)15.5, -4);
                }
                break;
            case 3:
                if (other.CompareTag("Player"))
                {
                    player.transform.position = new Vector3(50, 16, 15);
                    player.ActualVida = player.ActualVida - daño;
                }
                if (other.CompareTag("Premio"))
                {
                    reward.transform.position = new Vector3(6, (float)15.5, -44);
                }
                break;
        }


    }
}