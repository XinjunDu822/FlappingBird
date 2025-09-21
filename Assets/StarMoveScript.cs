using UnityEngine;

public class StarMoveScript : MonoBehaviour
{
    public float moveSpeed = 17;
    public float deadZone = -70;
    public LogicScript logic;
    public AudioSource pickUpSound;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
        pickUpSound = GameObject.Find("Star Pick Up Sound").GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += (Vector3.left * moveSpeed) * Time.deltaTime;
        if (transform.position.x < deadZone)
        {

            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 3 && !logic.isGameOver)
        {
            pickUpSound.Play();
            logic.addScore(3);
            Destroy(gameObject);
        }

    }
}
