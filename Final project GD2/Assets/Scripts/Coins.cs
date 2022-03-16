using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coins : MonoBehaviour
{
    public GameObject coin;
    public Rigidbody coinBody;
    public int speed;
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
