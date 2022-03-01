using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shootydrawbridge : MonoBehaviour
{
    [SerializeField] private float speed = 90;
    float yRotation = 90;
    

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision other)
    {
        yRotation += Time.deltaTime * speed;

        this.transform
    }
}
