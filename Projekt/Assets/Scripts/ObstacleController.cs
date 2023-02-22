using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class ObstacleController : MonoBehaviour
{
    public GameObject flower;
    public GameObject rock;
    public GameObject tree;
    public LayerMask obstacles;
    
    private int flowerint = 900;
    private int rockint = 25;
    private int treeint = 20;
    

    private float flowerrad = 0.2f;
    private float rockrad = 1f;
    private float treerad = 2f;
    

    void Awake() 
    {
        if (GameManager.instance.obstacles == 0)
        {
            SpawnObstacles(flower, flowerint, flowerrad);
        }
        
        else if (GameManager.instance.obstacles == 1)
        {
            SpawnObstacles(rock, rockint, rockrad);
        }
        
        else if (GameManager.instance.obstacles == 2)
        {
            SpawnObstacles(tree, treeint, treerad);
        }
    }

    void SpawnObstacles(GameObject model, int num, float rad)
    {
        for (int i = 0; i < num; i++)
        {
            Vector3 randomSpawnPosition = transform.position + new Vector3(randomFloat(-24f, +24f), 0, randomFloat(-24f, +24f));
            if (!Physics.CheckSphere(randomSpawnPosition, rad, obstacles))
            {
                Instantiate(model, randomSpawnPosition, Quaternion.Euler( 0, Random.Range( 0, 4 ) * 90, 0 ));
            }
            else
            {
                i--;
            }
        }
    }
    static float randomFloat(float min, float max){
        System.Random random = new System.Random();
        double val = (random.NextDouble() * (max - min) + min);
        return (float)val;
    }
}
