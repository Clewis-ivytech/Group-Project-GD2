using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BouncePad : MonoBehaviour
{
    [SerializeField] int speed;
    [SerializeField] GameObject Player1;
    [SerializeField] GameObject Player2;
    [SerializeField] GameObject Player3;
    [SerializeField] bool Boost;

    private void OnCollisionEnter(Collision collision)
    {
        if (Boost)
        {
            if (collision.gameObject.CompareTag("Character"))
            {
                Player1.gameObject.GetComponent<Rigidbody>().AddForce(Vector3.up * speed / 10);
                Player1.gameObject.GetComponent<Rigidbody>().AddForce(Vector3.forward * speed);
                //Player2.gameObject.GetComponent<Rigidbody>().AddForce(Vector3.up * speed / 10);   *Un-comment when char 2 added*
                //Player2.gameObject.GetComponent<Rigidbody>().AddForce(Vector3.forward * speed);
                Player3.gameObject.GetComponent<Rigidbody>().AddForce(Vector3.up * speed / 10);
                Player3.gameObject.GetComponent<Rigidbody>().AddForce(Vector3.forward * speed);
            }
        }

        else
        {
            if (collision.gameObject.CompareTag("Character"))
            {
                Player1.gameObject.GetComponent<Rigidbody>().AddForce(Vector3.up * speed);
                //Player2.gameObject.GetComponent<Rigidbody>().AddForce(Vector3.up * speed);   *Un-comment when char 2 added*
                Player3.gameObject.GetComponent<Rigidbody>().AddForce(Vector3.up * speed);
            }
        }
    }
}
