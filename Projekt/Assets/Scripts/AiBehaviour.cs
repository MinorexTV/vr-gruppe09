using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AiBehaviour : MonoBehaviour
{

    public NavMeshAgent agent;

    public LayerMask whatIsGround, whatIsPlayer;

    public Vector3 walkPoint;
    bool walkPointSet;
    public float walkPointRange;
    // Start is called before the first frame update

    private void Awake() {

        agent = GetComponent<NavMeshAgent>();

    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Patroling();
    }

    private void Patroling() {
        if (!walkPointSet) SearchWalkPointSet();

        if (walkPointSet)
            agent.SetDestination(walkPoint);

        Vector3 distanceToWalkPoint = transform.position - walkPoint;

        if (distanceToWalkPoint.magnitude < 1f)
        walkPointSet = false;

    }

    private void SearchWalkPointSet() {
        float randomZ = Random.Range(-walkPointRange, walkPointRange);
        float randomX = Random.Range(-walkPointRange, walkPointRange);

        walkPoint = new Vector3(transform.position.x + randomX, transform.position.y, transform.position.z + randomZ);

        if (Physics.Raycast(walkPoint, -transform.up, 2f, whatIsGround))
            walkPointSet = true; 

    }

}
