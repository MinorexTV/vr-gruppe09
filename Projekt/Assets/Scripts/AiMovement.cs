using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

//[RequireComponent(typeof(Rigidbody))]
[RequireComponent(typeof(NavMeshAgent))]

public class AiMovement : MonoBehaviour
{

    public NavMeshAgent agent;

    [Range(0, 100)] public float speed;
    [Range(1, 50)] public float walkRadius;

    public bool pausing;

    // Start is called before the first frame update
    void Start()
    {
        pausing = false;
        agent = GetComponent<NavMeshAgent>();
        if (agent != null)
        {
            agent.speed = speed;
            agent.SetDestination(RandomNavMeshLocation());
        }

        agent.baseOffset = 0.92f;

    }

    public Vector3 RandomNavMeshLocation()
    {

        Vector3 finalPosition = Vector3.zero;
        Vector3 randomPosition = Random.insideUnitSphere * walkRadius;
        randomPosition += transform.position;
        if (NavMesh.SamplePosition(randomPosition, out NavMeshHit hit, walkRadius, 1))
        {
            finalPosition = hit.position;
        }

        return finalPosition;

    }

    // Update is called once per frame
    void Update()
    {
        if (agent != null && agent.remainingDistance <= agent.stoppingDistance)
        {
            //agent.SetDestination(RandomNavMeshLocation());
            if (pausing == false)
            {
                StartCoroutine(ExampleCoroutine());
                pausing = true;
            }
        }
    }

    IEnumerator ExampleCoroutine()
    {
        yield return new WaitForSeconds(Random.Range(0, 3));
        agent.SetDestination(RandomNavMeshLocation());
        pausing = false;
    }

    void OnTriggerEnter(Collider col)
    {
        agent.SetDestination(RandomNavMeshLocation());
    }

    void OnCollisionEnter(Collision col)
    {
        agent.SetDestination(RandomNavMeshLocation());
    }
}
