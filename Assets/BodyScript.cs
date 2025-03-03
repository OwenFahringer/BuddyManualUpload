using UnityEngine;

public class BodyScript : MonoBehaviour
{
    public Rigidbody2D rightArmRb;
    public float rotationSpeed = 15f; // Adjust for smoothness (higher = snappier, lower = wobblier)

    void Update()
    {
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector2 direction = (mousePos - transform.position).normalized;

        float targetAngle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg +90; // FIX: Offset by -90°
        float currentAngle = rightArmRb.rotation;

        // Smoothly blend towards the target angle instead of instantly setting it
        float newAngle = Mathf.LerpAngle(currentAngle, targetAngle, Time.deltaTime * rotationSpeed * 90);

        rightArmRb.MoveRotation(newAngle);
    }
}
