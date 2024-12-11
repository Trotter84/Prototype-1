using UnityEngine;



public class FollowPlayer2 : MonoBehaviour
{
    public PlayerController player;
    private Vector3 offset;
    public int cameraOption;


    void Start()
    {
        SwapPosition(0);
    }

    void LateUpdate()
    {
        transform.position = player.transform.position + offset;
    }

    public void SwapPosition(int cameraOption)
    {
        switch (cameraOption)
        {
            case 0:
                offset = new Vector3(0, 6, -8);
                transform.rotation = Quaternion.Euler(19, 0, 0);
                break;
            case 1:
                offset = new Vector3(0, 8, -11);
                transform.rotation = Quaternion.Euler(19, 0, 0);
                break;
            case 2:
                offset = new Vector3(0, 2, 2.1f);
                transform.rotation = Quaternion.Euler(2, 0, 0);
                break;
        }
    }
}
