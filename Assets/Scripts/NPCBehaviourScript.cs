using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NPCBehaviourScript : MonoBehaviour
{
    public Transform player;
    private NavMeshAgent npc;
    void Start()
    {
        npc = GetComponent<NavMeshAgent>();
    }

    
    void Update()
    {
        npc.destination = player.position;       
    }
}
