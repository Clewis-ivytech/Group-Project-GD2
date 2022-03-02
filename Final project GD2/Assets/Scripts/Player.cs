using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Rigidbody playerBody;
    public GameObject player;
    public float Force = 20;
    public GameObject cameraStand;
    public float backwardsForce = 220;
    public float upwardsForce;
    bool isOnGround = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            playerBody.AddForce(Vector3.forward * Force);     
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            playerBody.AddForce(Vector3.forward * -Force);
        }
         else if (Input.GetKeyDown(KeyCode.A))
        {
            playerBody.AddForce(Vector3.left * Force);
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            playerBody.AddForce(Vector3.right * Force);
        }
        if (Input.GetKeyDown(KeyCode.Space) && isOnGround)
        {
            playerBody.AddForce(Vector3.up * upwardsForce);
            isOnGround = false;
        }
        

        cameraStand.transform.position = player.transform.position;
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Floor"))
        {
            isOnGround = true;
        }
    }

}
