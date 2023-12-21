using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playerlook : MonoBehaviour
{
    // Public variables accessible in the Unity Editor
    public Transform playerTransform;   // The player's transform to follow
    public Vector3 offset;              // Offset from the player's position
    public float rotationSpeed = 5f;    // Speed of camera rotation

    // Update is called once per frame
    void Update()
    {
        // Calculate the desired position of the camera
        Vector3 desiredPosition = playerTransform.position + offset;

        // Smoothly move the camera towards the desired position using Lerp
        transform.position = Vector3.Lerp(transform.position, desiredPosition, rotationSpeed * Time.deltaTime);

        // Calculate the rotation based on the player's input
        float mouseX = Input.GetAxis("Mouse X") * rotationSpeed;
        float mouseY = Input.GetAxis("Mouse Y") * rotationSpeed;

        // Rotate the player horizontally based on mouse movement
        playerTransform.Rotate(Vector3.up, mouseX);

        // Rotate the camera around the player vertically based on mouse movement
        transform.RotateAround(playerTransform.position, transform.right, -mouseY);
    }
}
