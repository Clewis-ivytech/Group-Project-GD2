using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public Rigidbody playerBody;
    public GameObject player;
    public float Force;
    public GameObject cameraStand;
    public float backwardsForce = 220;
    public float upwardsForce;
    bool isOnGround = true;
    public float speed;
    public float leftSpeed;
    public float rightSpeed;
    public float backSpeed;
    public float CoinsCollected = 0;
    public int sceneNumber = 1;
    // Start is called before the first frame update
    void Start()
    {
        CoinsCollected = 0;
    }   

    // Update is called once per frame
    void Update()
    {
        if (CoinsCollected == 5)
        {
            TriggerEnd();
            sceneNumber = sceneNumber + 1;
            
        }
        
        // Go Forward
        if (Input.GetKey(KeyCode.W) && speed < 50)
        {
            playerBody.AddForce(Vector3.forward * Force, ForceMode.Impulse);
            speed = speed + 1;
        }
        if (Input.GetKey(KeyCode.W) == false && speed > 0)
        {
            speed = speed - 1;
        }
        if ( speed == 50)
        {
            playerBody.velocity = playerBody.velocity / 2;
            playerBody.angularVelocity = playerBody.angularVelocity / 2;
            speed = 0;
        }
        // Go Backwards
        else if (Input.GetKey(KeyCode.S) && backSpeed < 50)
        {
            playerBody.AddForce(Vector3.back * Force, ForceMode.Impulse);
            backSpeed = backSpeed + 1;
        }
        if (Input.GetKey(KeyCode.S) == false && backSpeed > 0)
        {
            backSpeed = backSpeed - 1;
        }
        if (backSpeed == 50)
        {
            playerBody.velocity = playerBody.velocity / 2;
            playerBody.angularVelocity = playerBody.angularVelocity / 2 ;
            backSpeed = 0;
        }
        // Go Left
        else if (Input.GetKey(KeyCode.A) && leftSpeed < 50)
        {
            playerBody.AddForce(Vector3.left * Force, ForceMode.Impulse);
            leftSpeed = leftSpeed + 1;
        }
        if (Input.GetKey(KeyCode.A) == false && leftSpeed > 0)
        {
            leftSpeed = leftSpeed - 1;
        }
        if (leftSpeed == 50)
        {
            playerBody.velocity = playerBody.velocity / 2;
            playerBody.angularVelocity = playerBody.angularVelocity / 2;
            leftSpeed = 0;
        }

        //Go Right
        else if (Input.GetKey(KeyCode.D) && rightSpeed < 50)
        {
            playerBody.AddForce(Vector3.right * Force, ForceMode.Impulse);
            rightSpeed = rightSpeed + 1;
        }
        if (Input.GetKey(KeyCode.D) == false && rightSpeed > 0)
        {
            rightSpeed = rightSpeed - 1;
        }
        if (rightSpeed == 50)
        {
            playerBody.velocity = playerBody.velocity / 2;
            playerBody.angularVelocity = playerBody.angularVelocity / 2;
            rightSpeed = 0;
        }
        // Jump
        if (Input.GetKeyDown(KeyCode.Space) && isOnGround)
        {
            playerBody.AddForce(Vector3.up * upwardsForce);
            isOnGround = false;
        }
        // Reset on purpose
        if (Input.GetKeyDown(KeyCode.R))
        {
            //player.transform.position = new Vector3(-15, 10, -19);
            playerBody.velocity = Vector3.zero;
            playerBody.angularVelocity = Vector3.zero;
            speed = 0;
            backSpeed = 0;
            leftSpeed = 0;
            rightSpeed = 0;
            SceneManager.LoadScene(sceneNumber);
            Debug.Log(sceneNumber);

        }

        
        

        cameraStand.transform.position = player.transform.position;
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Floor"))
        {
            isOnGround = true;
        }
        if (collision.gameObject.CompareTag("Die")) 
        {
            
            playerBody.velocity = Vector3.zero;
            playerBody.angularVelocity = Vector3.zero;
            speed = 0;
            backSpeed = 0;
            leftSpeed = 0;
            rightSpeed = 0;
            Debug.Log(sceneNumber);
            SceneManager.LoadScene(sceneNumber);
        }
    }

    void TriggerEnd()
    {
       
        sceneNumber = sceneNumber + 1;
        SceneManager.LoadScene(sceneNumber);
        Debug.Log(sceneNumber);
    }

}
