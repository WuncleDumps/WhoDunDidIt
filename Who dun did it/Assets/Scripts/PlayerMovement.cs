using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementWithMouseLook : MonoBehaviour
{
    public float moveSpeed = 5.0f;
    public float mouseSensitivity = 2.0f;

    void Update()
    {
        HandleMovement();
        HandleMouseLook();
    }

    void HandleMovement()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector3 moveDirection = new Vector3(horizontal, 0.0f, vertical).normalized;
        Vector3 moveVelocity = moveDirection * moveSpeed;

        transform.Translate(moveVelocity * Time.deltaTime);
    }

    void HandleMouseLook()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity;

        // Left Right Look
        transform.Rotate(Vector3.up * mouseX);
    }
}
