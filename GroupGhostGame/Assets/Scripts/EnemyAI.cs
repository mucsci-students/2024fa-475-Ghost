using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

public class EnemyAI : MonoBehaviour
{
    private EnemyAware enemyAware;
    private Transform playerTransform;
    private NavMeshAgent agent;

    private void Start()
    {
        enemyAware = GetComponent<EnemyAware>();
        playerTransform = FindObjectOfType<FirstPersonController>().transform;
        agent = GetComponent<NavMeshAgent>();
    }

    private void Update()
    {
        if (enemyAware.isAggro)
        {
            agent.SetDestination(playerTransform.position);
        }
        else
        {
            agent.SetDestination(transform.position);
        }
    }
}
