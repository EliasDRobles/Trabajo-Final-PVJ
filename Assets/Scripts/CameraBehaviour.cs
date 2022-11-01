using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraBehaviour : MonoBehaviour
{

    public GameObject jugador;

    void Update()
    {
        transform.position = jugador.transform.position + new Vector3(0, 3, -4);
    }
}