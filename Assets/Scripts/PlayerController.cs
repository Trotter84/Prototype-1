using UnityEngine;


public class PlayerController : MonoBehaviour
{
    [Header("Components")]
    public FollowPlayer camera1;
    public FollowPlayer2 camera2;

    [Header("Player Attributes")]
    [SerializeField] [Range(1.0f, 30.0f)] private float playerSpeed = 20.0f;
    [SerializeField] private float turnSpeed = 30.0f;
    private float horizontalInput;
    private float forwardInput;
    [SerializeField] public bool player1;
    [SerializeField] public bool player2;


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            camera1.cameraOption++;
            if (camera1.cameraOption == 3)
            {
                camera1.cameraOption = 0;
            }
            camera1.SwapPosition(camera1.cameraOption);
        }

        if (Input.GetKeyDown(KeyCode.M))
        {
            camera2.cameraOption++;
            if (camera2.cameraOption == 3)
            {
                camera2.cameraOption = 0;
            }
            camera2.SwapPosition(camera2.cameraOption);
        }
    }

    void FixedUpdate()
    {
        PlayerMovement();
    }


    void PlayerMovement()
    {
        if (player1)
        {
            horizontalInput = Input.GetAxis("Player_1_Horizontal");
            forwardInput = Input.GetAxis("Player_1_Vertical");

            // Move the vehicle forward.
            transform.Translate(Vector3.forward * playerSpeed * Time.deltaTime * forwardInput);
            transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime * horizontalInput);
        }
        else if (player2)
        {
            horizontalInput = Input.GetAxis("Player_2_Horizontal");
            forwardInput = Input.GetAxis("Player_2_Vertical");

            // Move the vehicle forward.
            transform.Translate(Vector3.forward * playerSpeed * Time.deltaTime * forwardInput);
            transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime * horizontalInput);
        }

    }

}
