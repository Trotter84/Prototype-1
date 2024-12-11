using UnityEngine;

public class Propeller : MonoBehaviour
{
    [SerializeField] private float rotationSpeed = 41.7f;


    void Update()
    {
        transform.Rotate(0, 0, (rotationSpeed * 60) * Time.deltaTime);
    }
}
