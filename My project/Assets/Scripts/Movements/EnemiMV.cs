using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemiMV : MonoBehaviour
{
    public Transform playerTransform;
    public float movementSpeed = 1.5f;

    void Update()
    {
        // Check if the playerTransform is assigned
        if (playerTransform != null)
        {
            // Move the enemy towards the player
            MoveTowardsPlayer();
        }
        else
        {
            // Log a warning if the playerTransform is not assigned
            Debug.LogWarning("Player Transform not assigned in EnemyMovement script.");
        }
    }

    void MoveTowardsPlayer()
    {
        // Calculate the direction from the enemy to the player
        Vector3 direction = (playerTransform.position - transform.position).normalized;

        // Calculate the rotation to look at the player (optional)
        Quaternion lookRotation = Quaternion.LookRotation(direction);

        // Move the enemy towards the player
        transform.Translate(direction * movementSpeed * Time.deltaTime, Space.World);

        // Optional: Rotate the enemy to face the player
        transform.rotation = Quaternion.Slerp(transform.rotation, lookRotation, Time.deltaTime * 5f);
    }
}
