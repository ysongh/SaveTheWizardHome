using UnityEngine;

public class FireballSpawn : MonoBehaviour
{
    public Transform[] spawnPoints;

    public GameObject fireballPrefab;

    public float timeBetweenWaves = 1f;

    private float timeToSpawn = 3f;

    void Update()
    {
        if(Time.time >= timeToSpawn)
        {
            SpawnBlocks();
            
            timeToSpawn = Time.time + timeBetweenWaves;
        }
    }

    // spawn fireball
    void SpawnBlocks()
    {
        int randomFireball1 = Random.Range(0, spawnPoints.Length);
        int randomFireball2 = Random.Range(0, spawnPoints.Length);

        for(int i = 0; i < spawnPoints.Length; i++)
        {
            if(randomFireball1 == i || randomFireball2 == i)
            {
                Instantiate(fireballPrefab, spawnPoints[i].position, Quaternion.identity);
            }
            
        }
    }
}
