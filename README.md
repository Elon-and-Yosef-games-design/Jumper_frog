# Jumper_frog

Task 4A: https://elonnyosef.itch.io/task4aa

I've been created change of delay of 0.5s for laser shooter, and also add original change: red button that player can take and it wiil enter him to slo-motion mode of the game.

Task 4B: Video of the game: https://youtu.be/dmFqyQbe_B8

I created a simple game inspired by the classic game "Frogger." The main objective of the game is for the player-controlled frog to cross the road without being hit by cars. The game consists of several components, including the frog, cars, and the road with multiple tracks.

Here are the steps I followed to create the game:

- Create the game objects: I created the basic game objects in the Unity scene, including the frog, cars, and tracks.

- Implement car spawners: I added spawners for each track to generate cars at random intervals. To achieve this, I created an empty GameObject for each track, positioned it at the spawn point, and attached a script to instantiate cars at random intervals.

- Implement car movement: I wrote a script to move the cars across the screen from one side to the other. This script was attached to each car prefab. I used either the Translate method or the Rigidbody2D/3D.velocity to move the cars.

- Implement frog movement: I wrote a script to handle input from the arrow keys and move the frog accordingly. This script was attached to the frog GameObject. Like the car movement, I used either the Translate method or the Rigidbody2D/3D.velocity to move the frog.

- Implement collision detection: I wrote a script to check for collisions between the frog and cars using either OnCollisionEnter2D (for 2D) or OnCollisionEnter (for 3D). I attached the script to the frog GameObject. I also added a trigger to check if the frog reached the other side of the road successfully.

- Handle game events: In the collision detection script, I implemented logic to handle the frog getting hit by a car (e.g., reset the frog's position or reduce lives) and the frog successfully crossing the road (e.g., increase score).

- Display lives: I added a TextMeshProUGUI element to display the number of lives remaining. I created a script to update the lives text and attached it to a GameObject in the scene. I called the UpdateLivesText method from the frog script whenever the number of lives changed.
