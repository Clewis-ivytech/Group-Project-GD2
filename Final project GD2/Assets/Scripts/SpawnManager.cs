using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject RollerPrefabs;
    
    public float spawnPosZ;
    public float spawnInterval;
    public float startDelay;
    public float spawnPosX;
    public float spawnPosY;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRoller", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnRoller()
    {
        Vector3 spawnpos = new Vector3(spawnPosX, spawnPosY, spawnPosZ);
        Instantiate(RollerPrefabs, spawnpos, RollerPrefabs.transform.rotation);
    }
}
