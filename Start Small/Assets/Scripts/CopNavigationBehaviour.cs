using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class CopNavigationBehaviour : MonoBehaviour
{
    NavMeshAgent navAgent;


    void Start()
    {
        navAgent = GetComponent<NavMeshAgent>();
    }
    void Update()
    {
        
    }
}
