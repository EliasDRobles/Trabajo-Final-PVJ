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
        switch (nivel)
        {
            case 1:
                player.ActualVida = player.ActualVida - daño;
                other.transform.position = new Vector3(-50, 16, 15);
                    
        break;
            case 2:
                other.transform.position = new Vector3(0, 17, 15);
                player.ActualVida = player.ActualVida - daño;
                break;
            case 3:
                other.transform.position = new Vector3(50, 16, 15);
                player.ActualVida = player.ActualVida - daño;
                break;
            case 4:
                other.transform.position = new Vector3(0, 2, 0);
                break;
        }


    }
}