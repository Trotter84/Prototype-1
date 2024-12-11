using UnityEngine;

public class Propeller : MonoBehaviour
{
    [SerializeField] private float rotationSpeed = 41.7f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 0, (rotationSpeed * 60) * Time.deltaTime);
    }
}
