using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawner : MonoBehaviour
{

    public GameObject npcPrefab;
    public int npcnumber;
    public LayerMask obstacles;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < npcnumber; i++) {
            Vector3 randomSpawnPosition = new Vector3(Random.Range(-10,11), 0, Random.Range(-10,11));
             if (!Physics.CheckSphere (randomSpawnPosition, 1, obstacles)) {
                Instantiate(npcPrefab, randomSpawnPosition, Quaternion.identity);
                } else { i--;}
}
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
