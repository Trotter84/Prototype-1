using UnityEngine;


public class PlayerController : MonoBehaviour
{
    [Header("Player Attributes")]
    [SerializeField] [Range(1.0f, 30.0f)] private float playerSpeed = 20.0f;
    [SerializeField] private float turnSpeed = 30.0f;
    private float horizontalInput;
    private float forwardInput;


    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        // Move the vehicle forward.
        transform.Translate(Vector3.forward * playerSpeed * Time.deltaTime * forwardInput);
        transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime * horizontalInput);

    }
}
