using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileController : MonoBehaviour
{
    public float RotateX;
    public float RotateY;
    public float RotateZ;

    private void Update()
    {
        transform.Rotate(Vector3.right * Time.deltaTime * RotateX);
        transform.Rotate(Vector3.up * Time.deltaTime * RotateY);
        transform.Rotate(Vector3.forward * Time.deltaTime * RotateZ);
    }
}
