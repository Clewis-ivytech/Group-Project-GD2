using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileController : MonoBehaviour
{
    [SerializeField] float RotateX;
    [SerializeField] float RotateY;
    [SerializeField] float RotateZ;
    [SerializeField] bool BaF;
    [SerializeField] float speed = 0.36f;
    Vector3 pointA;
    Vector3 pointB;

    // Use this for initialization
    void Start()
    {
        //Get current position then add to its axis
        pointA = transform.eulerAngles + new Vector3(0f, 0f, 45f);

        //Get current position then substract to its axis
        pointB = transform.eulerAngles + new Vector3(0f, 0f, -45f);
    }

    private void Update()
    {
        transform.Rotate(Vector3.right * Time.deltaTime * RotateX);
        transform.Rotate(Vector3.up * Time.deltaTime * RotateY);
        transform.Rotate(Vector3.forward * Time.deltaTime * RotateZ);

        if (BaF)
        {
            //PingPong between 0 and 1
            float time = Mathf.PingPong(Time.time * speed, 1);
            transform.eulerAngles = Vector3.Lerp(pointA, pointB, time);
        }
    }
}
