using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    //create an array of GameObject cars
    public GameObject[] vehiclePrefabs;
    private float positionx = 5;
    private float positionz = 180;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomVehicle", 2, 2);
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    void SpawnRandomVehicle()
    {
        int index = Random.Range(0, vehiclePrefabs.Length);

        Vector3 spawnPostion = new Vector3(Random.Range(-positionx, positionx), 0, positionz);

        Instantiate(vehiclePrefabs[index], spawnPostion, vehiclePrefabs[index].transform.rotation);
    }
}
