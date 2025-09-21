using UnityEngine;

public class birdScript : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    public float flapStrength = 24.0f;
    //public float superFlapStrength;
    public AudioSource sound; 
    public LogicScript logic;
    public bool birdIsAlive = true;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
 
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < -35 || transform.position.y > 35) 
        {
            birdIsAlive = false;
            logic.gameOver();
        }
        if (Input.GetKeyDown(KeyCode.Space) == true && birdIsAlive == true)
        {
            sound.Play();
            myRigidbody.linearVelocity = Vector2.up * (flapStrength);
        }
        else if (Input.GetKeyDown(KeyCode.W) == true && birdIsAlive == true)
        {
            sound.Play();
            myRigidbody.linearVelocity = Vector2.up * (flapStrength * 1.8f);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        birdIsAlive = false;
        logic.gameOver();
    }
}
