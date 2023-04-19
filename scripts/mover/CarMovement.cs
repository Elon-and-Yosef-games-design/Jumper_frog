// This script controls the movement of a car
using UnityEngine;

public class CarMovement : MonoBehaviour
{
    // The speed at which the car moves
    public float speed = 5.0f;
    // The direction in which the car moves
    public Vector3 direction = Vector3.left;

    // A reference to the car's Rigidbody2D component
    private Rigidbody2D rb2D;

    void Start()
    {
        // Get a reference to the car's Rigidbody2D component
        rb2D = GetComponent<Rigidbody2D>(); 
    }

    void Update()
    {
        // Check if the reference to the Rigidbody2D component is not null
        if (rb2D != null)
        {
            // If yes, set the velocity of the Rigidbody2D component to the direction normalized and multiplied by the speed
            rb2D.velocity = direction.normalized * speed;
        }
    }
}
