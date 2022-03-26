using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BouncePad : MonoBehaviour
{
    public int speed;
    public GameObject Player1;
    public GameObject Player2;
    public GameObject Player3;

     private void OnCollisionEnter(Collision collision)
    {
       if (collision.gameObject.CompareTag("Character"))
        {
            Player1.gameObject.GetComponent<Rigidbody>().AddForce(Vector3.up * speed);
            //Player2.gameObject.GetComponent<Rigidbody>().AddForce(Vector3.up * speed);   *Un-comment when char 2 added*
            Player3.gameObject.GetComponent<Rigidbody>().AddForce(Vector3.up * speed);
        }
    }
}
