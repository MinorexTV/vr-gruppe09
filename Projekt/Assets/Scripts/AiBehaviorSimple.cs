using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AiBehaviorSimple : MonoBehaviour
{

    public Transform target;
    NavMeshAgent agent;
    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {

       /* if (agent.position = targeposition){
        float randomZ = Random.Range(-walkPointRange, walkPointRange);
        float randomX = Random.Range(-walkPointRange, walkPointRange);

        target = new Vector3(transform.position.x + randomX, transform.position.y, transform.position.z + randomZ);
        }*/
        agent.SetDestination(target.position);
    }
}
