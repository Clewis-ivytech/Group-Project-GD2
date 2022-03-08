using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileController : MonoBehaviour
{
    public float MoveX;
    public float MXtime;
    public float MoveY;
    public float MYtime;
    public float MoveZ;
    public float MZtime;
    public float RotateX;
    public float RotateY;
    public float RotateZ;
    public float ScaleX;
    public float ScaleY;
    public float ScaleZ;
    private bool Loop;

    void Awake()
    {
        MoveOnX();
        transform.Translate(Vector3.up * Time.deltaTime * MoveY);
        transform.Translate(Vector3.forward * Time.deltaTime * MoveZ);
        transform.Rotate(Vector3.right * Time.deltaTime * RotateX);
        transform.Rotate(Vector3.up * Time.deltaTime * RotateY);
        transform.Rotate(Vector3.forward * Time.deltaTime * RotateZ);
        transform.Rotate(Vector3.forward * Time.deltaTime * ScaleX);
        transform.Rotate(Vector3.forward * Time.deltaTime * ScaleY);
        transform.Rotate(Vector3.forward * Time.deltaTime * ScaleZ);
    }
    private void MoveOnX()
    {
        while (Loop == true)
        {
            transform.Translate(Vector3.right * Time.deltaTime * MoveX);
        }
    }
}
