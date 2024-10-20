using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorSystem : MonoBehaviour
{
    //Booleano que dictamina si esta cerrada o abierta
    private bool closed;
    //Velocidad a la que se abre
    private float openingSpeed;
    //Metodos accesores para closed
    public bool Closed { get => closed; set => closed = value; }
    
    void Start()
    {
        closed = true;
        openingSpeed = -0.002f;
    }
    //Metodo OpenDoor (Abrir la puerta)
    public void OpenDoor()
    {
        if (closed)
        {
            //Aplica transform sobre el objeto Nº2 (en este caso es 1)
            Transform openDoor = transform.GetChild(1).transform;
            while(openDoor.position.y > -2)
            {
                openDoor.Translate(0, openingSpeed * Time.deltaTime, 0);
            }
            closed = false;
        }
    }
}
