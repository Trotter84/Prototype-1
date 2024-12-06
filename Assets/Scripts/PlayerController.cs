using UnityEngine;


public class PlayerController : MonoBehaviour
{
    [Header("Player Attributes")]
    [SerializeField] [Range(1.0f, 30.0f)] private float playerSpeed = 20.0f;


    void Update()
    {
        // Move the vehicle forward.
        transform.Translate(Vector3.forward * playerSpeed * Time.deltaTime);
    }
}
