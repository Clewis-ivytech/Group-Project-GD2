using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coins : MonoBehaviour
{
    [SerializeField] GameObject coin;
    [SerializeField] Rigidbody coinBody;
    private int speed = 25;
    // Start is called before the first frame update
    void Start()
    {
        coinBody.AddRelativeTorque(Vector3.up * Random.Range(1, 10));
    }

    // Update is called once per frame
    void Update()
    {
        coinBody.AddRelativeTorque(Vector3.up * speed);
    }
}
