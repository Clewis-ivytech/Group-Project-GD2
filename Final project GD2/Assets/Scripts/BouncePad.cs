using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BouncePad : MonoBehaviour
{
    [SerializeField] int speed;
    [SerializeField] GameObject Player;
    [SerializeField] bool Boost;

    private void OnCollisionEnter(Collision collision)
    {
        if (Boost)
        {
            if (collision.gameObject.CompareTag("Character"))
            {
                Player.gameObject.GetComponent<Rigidbody>().AddForce(Vector3.up * speed / 10);
                Player.gameObject.GetComponent<Rigidbody>().AddForce(Vector3.forward * speed);
            }
        }

        else
        {
            if (collision.gameObject.CompareTag("Character"))
            {
                Player.gameObject.GetComponent<Rigidbody>().AddForce(Vector3.up * speed);
            }
        }
    }
}
