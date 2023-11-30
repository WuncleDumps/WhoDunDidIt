using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementWithMouseLook : MonoBehaviour
{
    public float moveSpeed = 5.0f;
    public float mouseSensitivity = 2.0f;

    void Update()
    {
        // Player movement
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector3 moveDirection = new Vector3(horizontal, 0.0f, vertical).normalized;
        Vector3 moveVelocity = moveDirection * moveSpeed;

        transform.Translate(moveVelocity * Time.deltaTime);

        // Mouse look
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity;

        transform.Rotate(Vector3.up * mouseX);

        // Vertical rotation is clamped to avoid flipping the camera
        float newRotationX = Mathf.Clamp(transform.rotation.eulerAngles.x - mouseY, -90.0f, 90.0f);
        Camera.main.transform.rotation = Quaternion.Euler(newRotationX, transform.rotation.eulerAngles.y, 0.0f);
    }
}
