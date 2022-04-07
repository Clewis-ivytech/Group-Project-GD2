using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BouncePad : MonoBehaviour
{
    [SerializeField] int speed;
    [SerializeField] int temp;
    [SerializeField] GameObject Player;
    [SerializeField] bool Boost;
    private int currentChar;
    private bool char1Active;
    private bool char2Active;
    private bool char3Active;

    private void OnCollisionEnter(Collision collision)
    {
        void Start()
        {
            temp = speed;
            currentChar = PlayerPrefs.GetInt("CharacterSelected");
            if (currentChar == 1)
            {
                char1Active = true;
            }
            if (currentChar == 2)
            {
                char2Active = true;
            }
            if (currentChar == 3)
            {
                char3Active = true;
            }
        }
       
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
            if(char3Active == true)
        {
            speed = 0;
        }
        else
        {
            speed = temp;
        }

        
    }
}
