using UnityEngine;

public class Player : MonoBehaviour
{
    private CharacterController controller;
    private Vector3 playerVelocity;
    public bool groundedPlayer;
    public float jumpHeight = 4.0f;
    public float gravityValue = -45.0f;
    public float speed = 5f;
    public static int collisionCount = 0;
    private int enemyHits = 0;

    void Start()
    {
        controller = gameObject.GetComponent<CharacterController>();
    }

    void Update()
    {
        groundedPlayer = controller.isGrounded;

        float xDirection = Input.GetAxis("Horizontal");
        float zDirection = Input.GetAxis("Vertical");

        if (groundedPlayer && playerVelocity.y < 0)
        {
            playerVelocity.y = 0f;
        }

        Vector3 moveDirection = new Vector3(xDirection, 0.0f, zDirection);
        controller.Move(moveDirection * Time.deltaTime * speed);

        if (moveDirection != Vector3.zero)
        {
            gameObject.transform.forward = moveDirection;
        }

        if (Input.GetButtonDown("Jump") && groundedPlayer)
        {
            playerVelocity.y += Mathf.Sqrt(jumpHeight * -3.0f * gravityValue);
        }

        playerVelocity.y += gravityValue * Time.deltaTime;
        controller.Move(playerVelocity * Time.deltaTime);
    }

    //PLAYER COLLISION CHECK
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            enemyHits++;
            OneCollision(enemyHits);
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Wall")
        {
            Counter.collisions++;
            print(collisionCount + " collisions detected.");
        }
    }

    void OneCollision(int hits)
    {
        if (enemyHits == 2)
        {
            Counter.collisions++;
            print(collisionCount + " collisions detected.");
            enemyHits = 0;
        }
    }
}
