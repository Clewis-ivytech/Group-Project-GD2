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

            Debug.Log("Player collided with bouncepad");
            Player.gameObject.GetComponent<Rigidbody>().AddForce(Vector3.up * speed);
        }
    }

    /*void OnCollisionEnter(Collision col)
    {
        if (col.collider.gameObject == Player)
        {
            Debug.Log("Player collided with bouncepad");
            Destroy(gameObject);
        }
    }*/
}
