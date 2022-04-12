using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] GameObject RollerPrefab;
    [SerializeField] GameObject BoulderPrefab;
    [SerializeField] GameObject IceBoulderPrefab;
    [SerializeField] GameObject IceBoulder2Prefab;
    [SerializeField] GameObject IceBoulder3Prefab;
    [SerializeField] bool Roller;
    [SerializeField] bool Boulder;
    [SerializeField] bool IceBoulder;
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
        else if (IceBoulder)
        {
            InvokeRepeating("SpawnIceBoulder", 0, 6);
            InvokeRepeating("SpawnIceBoulder2", 4, 10);
            InvokeRepeating("SpawnIceBoulder3", 4, 7);
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

    void SpawnIceBoulder()
    {
        Vector3 spawnpos = new Vector3(-15f, 75f, 60f);
        Instantiate(IceBoulderPrefab, spawnpos, IceBoulderPrefab.transform.rotation);
    }
    void SpawnIceBoulder2()
    {
        Vector3 spawnpos = new Vector3(-15f, 50f, 144f);
        Instantiate(IceBoulder2Prefab, spawnpos, IceBoulderPrefab.transform.rotation);
    }
    void SpawnIceBoulder3()
    {
        Vector3 spawnpos = new Vector3(34f, 27f, 370f);
        Instantiate(IceBoulder3Prefab, spawnpos, IceBoulderPrefab.transform.rotation);
    }
}
