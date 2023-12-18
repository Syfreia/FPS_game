using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovements : MonoBehaviour
{
    public float movementSpeed = 5f;
    public float rotationSpeed = 180f;

    void Update()
    {
        // Get input for movement and rotation
        float movementInput = Input.GetAxis("Vertical");
        float rotationInput = Input.GetAxis("Horizontal");

        // Calculate movement direction
        Vector3 movementDirection = Vector3.forward * movementInput;

        // Normalize movement direction
        movementDirection.Normalize();

        // Calculate movement amount
        Vector3 movementAmount = movementDirection * movementSpeed;

        // Translate the player's position
        transform.Translate(movementAmount * Time.deltaTime);

        // Calculate rotation amount
        float rotationAmount = rotationInput * rotationSpeed;

        // Rotate the player's transform
        transform.Rotate(Vector3.up, rotationAmount * Time.deltaTime);
    }
}