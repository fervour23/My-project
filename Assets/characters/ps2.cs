using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ps2 : MonoBehaviour
{
    [SerializeField] private Transform[] movePositions; // Array with two targets
    private NavMeshAgent navMeshAgent;
    private Transform selectedTarget;

    private void Awake()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();

        if (movePositions.Length > 0)
        {
            int randomIndex = Random.Range(0, movePositions.Length); // Choose randomly once
            selectedTarget = movePositions[randomIndex];
        }
    }

    private void Update()
    {
        if (selectedTarget != null)
        {
            navMeshAgent.destination = selectedTarget.position;
        }
    }
}
