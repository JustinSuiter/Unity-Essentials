using UnityEngine;

public class DayNightCycle : MonoBehaviour
{
    [Tooltip("Time (in seconds) it takes to complete a full day cycle (360° rotation).")]
    public float dayLengthInSeconds = 120f;

    private float rotationSpeed;

    void Start()
    {
        // Calculate rotation speed in degrees per second
        rotationSpeed = 360f / dayLengthInSeconds;
    }

    void Update()
    {
        // Rotate around X-axis to simulate the sun moving
        transform.Rotate(Vector3.right * rotationSpeed * Time.deltaTime);
    }
}
