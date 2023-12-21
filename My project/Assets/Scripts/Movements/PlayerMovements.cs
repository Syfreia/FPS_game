using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovements : MonoBehaviour
{
    // Public variable accessible in the Unity Editor
    public float movementSpeed = 5f;  // Speed of player movement

    // Update is called once per frame
    void Update()
    {
        // Get input for movement
        float verticalInput = Input.GetAxis("Vertical");
        float horizontalInput = Input.GetAxis("Horizontal");

        // Calculate movement amount based on input
        Vector3 movementAmount = new Vector3(horizontalInput, 0f, verticalInput) * movementSpeed;

        // Translate the player's position based on the calculated movement amount
        // Space.Self indicates movement relative to the player's local coordinate system
        transform.Translate(movementAmount * Time.deltaTime, Space.Self);
    }
}
