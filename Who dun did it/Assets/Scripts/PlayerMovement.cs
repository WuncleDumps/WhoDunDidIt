using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementWithMouseLook : MonoBehaviour
{
    public float moveSpeed = 5.0f;
    public float mouseSensitivity = 2.0f;

    private float rotationX = 0.0f;

    void Update()
    {
        // Arrow Movement
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector3 moveDirection = new Vector3(horizontal, 0.0f, vertical).normalized;
        Vector3 moveVelocity = moveDirection * moveSpeed;

        transform.Translate(moveVelocity * Time.deltaTime);

        // Mouse look
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity;

        // Horizontal Rotation
        transform.Rotate(Vector3.up * mouseX);

        // Vertical Rotation
        rotationX -= mouseY;
        rotationX = Mathf.Clamp(rotationX, -90.0f, 90.0f);

        transform.localRotation = Quaternion.Euler(rotationX, transform.localRotation.eulerAngles.y, 0.0f);
    }
}

