using UnityEngine;


public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    private Vector3 cameraOffset = new Vector3(0, 6, -8);

    void Start()
    {
        
    }

    void LateUpdate()
    {
        // Offset the camera behind the player by adding to the player's position.
        transform.position = player.transform.position + cameraOffset;
    }
}
