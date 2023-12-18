using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform playerTransform;
    public Vector3 offset;
    public float rotationSpeed = 5f;

    void Update()
    {
        // Calculate the desired position of the camera
        Vector3 desiredPosition = playerTransform.position + offset;

        // Smoothly move the camera towards the desired position
        transform.position = Vector3.Lerp(transform.position, desiredPosition, rotationSpeed * Time.deltaTime);

        // Calculate the rotation based on the player's input
        float mouseX = Input.GetAxis("Mouse X") * rotationSpeed;
        float mouseY = Input.GetAxis("Mouse Y") * rotationSpeed;

        // Rotate the camera around the player horizontally
        playerTransform.Rotate(Vector3.up, mouseX);

        // Rotate the camera around the player vertically
        transform.RotateAround(playerTransform.position, transform.right, -mouseY);
    }
}