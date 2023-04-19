// This script is for spawning a car object. 
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarSpawner : MonoBehaviour
{
    // The prefab of the car that will be spawned
    public GameObject carPrefab;

    // The time interval between each car spawn
    public float spawnInterval = 3.0f;

    // A timer to keep track of the time passed since the last spawn
    private float timer;

    void Update()
    {
        // Increase the timer by the time passed since the last frame
        timer += Time.deltaTime;

        // Check if the timer has reached the spawn interval
        if (timer >= spawnInterval)
        {
            // If yes, spawn a car and reset the timer
            SpawnCar();
            timer = 0;
        }
    }

    // A function to spawn a car
    private void SpawnCar()
    {
        // The position where the car will be spawned
        Vector3 spawnPosition = transform.position;
        // The rotation of the car when it is spawned
        Quaternion spawnRotation = Quaternion.identity; 

        // Instantiate the car at the spawn position and rotation
        GameObject spawnedCar = Instantiate(carPrefab, spawnPosition, spawnRotation);
    }
}
