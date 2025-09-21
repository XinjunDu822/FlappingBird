using UnityEngine;

public class StarSpawnScript : MonoBehaviour
{
    public GameObject star;
    public float spawnRate = 4;
    //public double firstSpawnRate = 1.5;
    public double firstSpawnRate = 1;
    private float timer = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
 
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < firstSpawnRate)
        {
            timer += Time.deltaTime;
        }
        else if (timer > firstSpawnRate && timer < 2)
        {
            spawnStar();
            timer = 2;
        }
        else
        {
            if (timer < spawnRate)
            {
                timer += Time.deltaTime;
            }
            else  
            {
                spawnStar();
                timer = 2;
            }
        }
    }

    void spawnStar()
    {
        Instantiate(star, new Vector3(transform.position.x, Random.Range(-22, 24), 0), transform.rotation);
    }
}
