using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Se encarga de devolver al jugador al inicio del nivel que se encuentre
public class ResetPlayer : MonoBehaviour
{

    [SerializeField]
    private int nivel;

    private void OnTriggerEnter(Collider other)
    {
        switch (nivel)
        {
            case 1:
                other.transform.position = new Vector3(-50, 16, 15);
                break;
            case 2:
                other.transform.position = new Vector3(0, 17, 15);
                break;
            case 3:
                other.transform.position = new Vector3(50, 16, 15);
                break;
            case 4:
                other.transform.position = new Vector3(0, 2, 0);
                break;
        }


    }
}