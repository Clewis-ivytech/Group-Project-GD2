using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] GameObject RollerPrefab;
    [SerializeField] GameObject BoulderPrefab;
    [SerializeField] bool Roller;
    [SerializeField] bool Boulder;
    [SerializeField] float DestroyTime;


    // Start is called before the first frame update
    void Start()
    {
        if (Roller)
        {
            InvokeRepeating("SpawnRoller", 4, 5);
        }
        else if (Boulder)
        {
            InvokeRepeating("SpawnBoulder", 10, 4);
        }
        else
        {
            Destroy(gameObject, DestroyTime);
        }
    }

    void SpawnRoller()
    {
        Vector3 spawnpos = new Vector3(-15, 50, 362);
        Instantiate(RollerPrefab, spawnpos, RollerPrefab.transform.rotation);
    }

    void SpawnBoulder()
    {
        Vector3 spawnpos = new Vector3(54.6f, 84f, 1455f);
        Instantiate(BoulderPrefab, spawnpos, BoulderPrefab.transform.rotation);
    }
}