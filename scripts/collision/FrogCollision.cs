// This script handles the frog's collision with cars and goal objects
using UnityEngine;
using UnityEngine.UI;

public class FrogCollision : MonoBehaviour
{
    // The tag name for cars in the game
    public string carTag = "Car";
    // The tag name for the goal object in the game
    public string goalTag = "Goal";
    // The number of lives the frog starts with
    public int lives = 3;
    // The current score of the player
    public int score = 0;
    // A reference to the UI text component that displays the number of lives
    public Text livesText;

    // The starting position of the frog
    private Vector3 startingPosition;

    private void Start()
    {
        // Save the starting position of the frog
        startingPosition = transform.position;
    }

    // A function that is called when the frog collides with another collider
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Check if the collider has the "Car" tag
        if (collision.gameObject.CompareTag(carTag))
        {
            // Log a message indicating that the frog was hit by a car
            Debug.Log("Frog hit by a car!");
            // Decrease the number of lives
            lives--;
            // Update the lives display
            UpdateLivesDisplay();
            // Log the number of lives left
            Debug.Log("Lives left: " + lives);

            // Check if the frog still has lives left
            if (lives > 0)
            {
                // If yes, reset the frog's position
                ResetFrogPosition();
            }
            else
            {
                // If no, log a message indicating that the game is over
                Debug.Log("Game Over!");
                // Add logic for handling game over (show game over screen...)
            }
        }
    }

    // A function that is called when the frog enters a trigger collider
    private void OnTriggerEnter2D(Collider2D other)
    {
        // Check if the trigger collider has the "Goal" tag
        if (other.CompareTag(goalTag))
        {
            // Log a message indicating that the frog reached the other side
            Debug.Log("Frog reached the other side!");
            // Increase the score
            score++;
            // Log the current score
            Debug.Log("Score: " + score);

            // Reset the frog's position
            ResetFrogPosition();
            // Add logic for handling frog successfully crossing the road (move to the next level...)
        }
    }

    // A function to update the lives display
    private void UpdateLivesDisplay()
    {
        // Set the text of the lives display to "Lives: " followed by the number of lives
        livesText.text = "Lives: " + lives.ToString();
    }

    // A function to reset the frog's position
    private void ResetFrogPosition()
    {
        // Set the position of the frog to the starting position
        transform.position = startingPosition;
    }
}
