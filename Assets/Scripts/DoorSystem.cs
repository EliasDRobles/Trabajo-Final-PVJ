using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorSystem : MonoBehaviour
{
    private bool closed;
    private float openingSpeed;

    public bool Closed { get => closed; set => closed = value; }
    // Start is called before the first frame update
    void Start()
    {
        closed = true;
        openingSpeed = -0.002f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OpenDoor()
    {
        if (closed)
        {
            Transform openDoor = transform.GetChild(1).transform;
            while(openDoor.position.y > -2)
            {
                openDoor.Translate(0, openingSpeed * Time.deltaTime, 0);
            }
            closed = false;
        }
    }
}
