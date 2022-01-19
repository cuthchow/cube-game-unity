using UnityEngine;

public class PlayerCollision : MonoBehaviour
{

    public PlayerMovement movement;
    public Rigidbody rigidbody;
    public GameObject player;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Obstacle")
        {
            Debug.Log("We hit an obstacle!");
            rigidbody.useGravity = false;
            movement.enabled = false;

            rigidbody.AddForce(0, 2500, 0);

            // Finding the GameManager (Rather than using variable reference)
            // So that reference to it doesn't die with our player

            FindObjectOfType<GameManager>().endGame();
        }
    }
}
