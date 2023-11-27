using UnityEngine;

public class MovementAndRotationController : MonoBehaviour
{
    public float moveSpeed = 5.0f;
    public float rotateSpeed = 100.0f;
    public Camera arCamera; // Reference to the AR camera

    // Movement Methods
    public void MoveUp() => Move(arCamera.transform.forward); // Forward relative to the camera
    public void MoveDown() => Move(-arCamera.transform.forward); // Backward relative to the camera
    public void MoveLeft() => Move(-arCamera.transform.right); // Left relative to the camera
    public void MoveRight() => Move(arCamera.transform.right); // Right relative to the camera

    // Rotation Methods
    public void RotateUp() => Rotate(Vector3.right); // Rotating around the right axis moves the top upwards
    public void RotateDown() => Rotate(Vector3.left); // Rotating around the left axis moves the top downwards
    public void RotateLeft() => Rotate(Vector3.up); // Rotating around the up axis moves the left side up
    public void RotateRight() => Rotate(Vector3.down); // Rotating around the down axis moves the right side up

    private void Move(Vector3 direction)
    {
        transform.Translate(direction * moveSpeed * Time.deltaTime, Space.World);
    }

    private void Rotate(Vector3 axis)
    {
        transform.Rotate(axis * rotateSpeed * Time.deltaTime, Space.World);
    }
}
