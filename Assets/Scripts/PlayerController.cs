using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5.0f; // meters per sec
    public float turnSpeed = 45.0f; // degrees per sec
    private float verticalInput;
    private float horizontalInput;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // Read the inputs
        verticalInput = Input.GetAxis("Vertical");
        horizontalInput = Input.GetAxis("Horizontal");

        // Move the vehicle forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput);
        // Turn the vehicle
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);
    }
}
