// This script controls the movement of a frog 
using UnityEngine;

public class FrogMovement : MonoBehaviour
{
    // The speed at which the frog moves
    public float speed = 3.0f;

    // A reference to the frog's Rigidbody2D component
    private Rigidbody2D rb2D; 

    void Start()
    {
        // Get a reference to the frog's Rigidbody2D component
        rb2D = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // Get the horizontal and vertical input axis values
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        // Calculate the move direction as the normalized sum of the horizontal and vertical input axis values
        Vector3 moveDirection = new Vector3(horizontal, vertical, 0).normalized;

        // Check if the reference to the Rigidbody2D component is not null
        if (rb2D != null)
        {
            // If yes, set the velocity of the Rigidbody2D component to the move direction multiplied by the speed
            rb2D.velocity = moveDirection * speed;
        }
    }
}
