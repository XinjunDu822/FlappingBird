using UnityEngine;

public class EnemyBirdMoveScript : MonoBehaviour
{
    public float moveSpeed = 28;
    public float deadZone = -70;
    public LogicScript logic;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
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
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.layer == 3 && !logic.isGameOver)
        {
            logic.gameOver();
        }

    }
}
