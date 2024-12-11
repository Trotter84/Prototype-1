using UnityEngine;


public class NPCCar : MonoBehaviour
{
    [SerializeField] private int npcId;
    public float npcCarSpeed = 30.0f;

    [SerializeField] private Transform player1;
    [SerializeField] private Transform player2;
    

    void Start()
    {
        player1 = GameObject.Find("Player_1_Vehicle").GetComponent<Transform>();
        player2 = GameObject.Find("Player_2_Vehicle").GetComponent<Transform>();
    }

    void Update()
    {
        transform.Translate(Vector3.forward * npcCarSpeed * Time.deltaTime);

        DeSpawnVehicle();
    }

    void DeSpawnVehicle()
    {
        if (transform.position.z < (player1.position.z - 15) && transform.position.z < (player2.position.z - 15))
        {
            gameObject.SetActive(false);
        }
    }
}
