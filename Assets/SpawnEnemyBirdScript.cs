using UnityEngine;

public class SpawnEnemyBirdScript : MonoBehaviour
{
    public GameObject enemyBird;
    public float minSpawnTime = 2f;
    public float maxSpawnTime = 5f;
    private float timer = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < 3)
        {
            timer += Time.deltaTime;
        }
        else
        {
            Invoke("spawnEnemyBird", Random.Range(minSpawnTime, maxSpawnTime = 5f));
            timer = 0; 
        }
    }

    void spawnEnemyBird()
    {
        Instantiate(enemyBird, new Vector3(transform.position.x, Random.Range(-25, 27), 0), transform.rotation);
    }
}
