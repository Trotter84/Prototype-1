using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CarSpawner : MonoBehaviour
{
    private int carId;

    [Header("Prefabs")]
    [SerializeField] private GameObject spawningVehiclePrefab;
    [SerializeField] private GameObject carPrefab, truckPrefab, busPrefab, tankPrefab;

    [Header("Vehicle Pool")]
    [SerializeField] private int vehicleCountToPool = 4;
    [SerializeField] private List<GameObject> pooledVehicles = new List<GameObject>();
    
    [SerializeField] private bool gameIsRunning = false;
    private int lastRoll;


    void Awake()
    {
        gameIsRunning = true;
    }

    void Start()
    {   
        InitiatePool();
        StartCoroutine(SpawnVehicleRoutine());   
    }

    void CarPicker()
    {
        int i = Random.Range(0, 4);
        
        while (i == lastRoll)
        {
            i = Random.Range(0, 4);
        }
        
        switch (i)
        {
            case 0:
                spawningVehiclePrefab = carPrefab;
                break;
            case 1:
                spawningVehiclePrefab = truckPrefab;
                break;
            case 2:
                spawningVehiclePrefab = busPrefab;
                break;
            case 3:
                spawningVehiclePrefab = tankPrefab;
                break;
        }
        lastRoll = i;
    }

    private void InitiatePool()
    {
        for (int i = 0; i < vehicleCountToPool; i++)
        {
            CarPicker();
            GameObject vehicles = Instantiate(spawningVehiclePrefab);
            vehicles.transform.parent = transform;
            vehicles.SetActive(false);
            pooledVehicles.Add(vehicles);
        }
    }

    public GameObject GetPooledVehicles()
    {
        for (int i = 0; i < pooledVehicles.Count; i++)
        {
            if (!pooledVehicles[i].activeInHierarchy)
            {
                return pooledVehicles[i];
            }
        }
        return null;
    }

    IEnumerator SpawnVehicleRoutine()
    {
        while (gameIsRunning)
        {
            GameObject vehicle = GetPooledVehicles();
            if (vehicle != null)
            {
                vehicle.transform.position = new Vector3(Random.Range(-5, 6), 0, 170);
                vehicle.SetActive(true);
            }
            yield return new WaitForSeconds(1.0f);
        }
    }
}
