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
}
