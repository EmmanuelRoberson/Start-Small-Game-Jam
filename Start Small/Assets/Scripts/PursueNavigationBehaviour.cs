using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class PursueNavigationBehaviour : MonoBehaviour
{
    public Transform objectToPursue;

    private NavMeshAgent navMeshAgent;

    private Vector3 targetPosition;

    public float stuckCooldown;

    private float stuckCooldownTimer;

    // Start is called before the first frame update
    void Start()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();

        targetPosition = objectToPursue.position;

        navMeshAgent.SetDestination(targetPosition);

        stuckCooldownTimer = stuckCooldown;
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(transform.position, targetPosition) < 1)
        {
            targetPosition = objectToPursue.position;

            navMeshAgent.SetDestination(targetPosition);
        }

        if (navMeshAgent.velocity.magnitude <= 0)
        {
            stuckCooldownTimer -= Time.deltaTime;
        }

        if (stuckCooldownTimer <= 0)
        {
            ResetTarget();

            stuckCooldownTimer = stuckCooldown;
        }
    }

    private void ResetTarget()
    {
        targetPosition = objectToPursue.position;

        navMeshAgent.SetDestination(targetPosition);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene(0);
        }
    }
}
