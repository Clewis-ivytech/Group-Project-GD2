using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BouncePad : MonoBehaviour
{
    public int speed;
    public GameObject Player;

     private void OnCollisionEnter(Collision collision)
    {
       if (collision.gameObject.CompareTag("Character"))
        {
            Player.gameObject.GetComponent<Rigidbody>().AddForce(Vector3.up * speed);
        }
    }
}
