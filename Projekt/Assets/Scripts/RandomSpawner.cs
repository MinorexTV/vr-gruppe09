using UnityEngine;

public class RandomSpawner : MonoBehaviour
{
    public GameObject npcPrefab;
    public GameObject goldennpcPrefab;

    public LayerMask obstacles;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < GameManager.instance.npcs - GameManager.instance.goldennpcs; i++)
        {
            Vector3 randomSpawnPosition =
                transform.position + new Vector3(randomFloat(-24f, +24f), 0, randomFloat(-24f, +24f));
            if (!Physics.CheckSphere(randomSpawnPosition, 1, obstacles))
            {
                Instantiate(npcPrefab, randomSpawnPosition, Quaternion.identity);
            }
            else
            {
                i--;
            }
        }

        for (int i = 0; i < GameManager.instance.goldennpcs; i++)
        {
            Vector3 randomSpawnPosition =
                transform.position + new Vector3(randomFloat(-24f, +24f), 0, randomFloat(-24f, +24f));
            if (!Physics.CheckSphere(randomSpawnPosition, 1, obstacles))
            {
                Instantiate(goldennpcPrefab, randomSpawnPosition, Quaternion.identity);
            }
            else
            {
                i--;
            }
        }
    }

    static float randomFloat(float min, float max)
    {
        System.Random random = new System.Random();
        double val = (random.NextDouble() * (max - min) + min);
        return (float)val;
    }
}