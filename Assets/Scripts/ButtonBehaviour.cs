using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonBehaviour : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        DoorSystem door = GameObject.Find("DoorSystem").GetComponent<DoorSystem>();
        if (other.CompareTag("Premio") && (door.Closed))
        {
            door.OpenDoor();
        }
    }
}
