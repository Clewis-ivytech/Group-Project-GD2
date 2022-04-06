using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    [SerializeField] Rigidbody playerBody;
    [SerializeField] GameObject player;
    private float Force = 0.4f;
    [SerializeField] GameObject cameraStand;
    // private float backwardsForce = 200;
    private float upwardsForce = 450;
    bool isOnGround = true;
    private float speed;
    private float leftSpeed;
    private float rightSpeed;
    private float backSpeed;
    [HideInInspector] public float CoinsCollected = 0;
    public int sceneNumber = 1;
    private bool Active;
    private int Lock3;

    private int NewLvl2;
    private int NewLvl3;
    private int NewLvl4;
    private int NewLvl5;

    private int TotalDeaths;
    private int TotalJumps;
    private int TotalResets;

    private int currentChar;
    private bool char1Active = false;
    private bool char2Active = false;
    private bool char3Active = false;


    // Start is called before the first frame update
    private void Start()
    {
        CoinsCollected = 0;
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

    // Update is called once per frame
    private void Update()
    {
        if (CoinsCollected == 5)
        {

            if (sceneNumber == 1)
            {
                FinishOne();
            }
            if (sceneNumber == 2)
            {
                FinishTwo();
            }
            if (sceneNumber == 3)
            {
                FinishThree();
            }
            if (sceneNumber == 4)
            {
                FinishFour();
            }
            if (sceneNumber == 5)
            {
                FinishFive();
            }
        }

        //King K Roller
        if (char1Active)
        {
            player.GetComponent<Rigidbody>().useGravity = true;
            if (Input.GetKey(KeyCode.W) && speed < 50)
            {
                playerBody.AddForce(Vector3.forward * Force, ForceMode.Impulse);
                speed = speed + 1;
            }
            if (Input.GetKey(KeyCode.W) == false && speed > 0)
            {
                speed = speed - 1;
            }
            if (speed == 50)
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
                playerBody.angularVelocity = playerBody.angularVelocity / 2;
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

                // jumping
                TotalJumps = PlayerPrefs.GetInt("TotalJumps");
                PlayerPrefs.SetInt("TotalJumps", TotalJumps + 1);

<<<<<<< HEAD
            TotalJumps = PlayerPrefs.GetInt("LTotalJumps");
            PlayerPrefs.SetInt("LTotalJumps", TotalJumps + 1);
=======
            }
        }
        //Colin Christ
        if (char3Active)
        {
            player.GetComponent<Rigidbody>().useGravity = false;
            if (Input.GetKey(KeyCode.Space))
            {
                player.transform.Translate(Vector3.up * Force / 3);
            }
            if (Input.GetKey(KeyCode.LeftShift))
            {
                player.transform.Translate(Vector3.up * -Force / 3);
            }
            if (Input.GetKey(KeyCode.W))
            {
                player.transform.Translate(Vector3.forward * Force / 2);
            }
            if (Input.GetKey(KeyCode.S))
            {
                player.transform.Translate(Vector3.forward * -Force / 2);
            }
            if (Input.GetKey(KeyCode.A))
            {
                player.transform.Translate(Vector3.left * Force / 2);
            }
            if (Input.GetKey(KeyCode.D))
            {
                player.transform.Translate(Vector3.left * -Force / 2);
            }
>>>>>>> Nathan
        }
        // Reset on purpose
        if (sceneNumber > 0)
        {
            if (Input.GetKeyDown(KeyCode.R))
            {
                //when resetting
                TotalResets = PlayerPrefs.GetInt("TotalResets");
                PlayerPrefs.SetInt("TotalResets", TotalResets + 1);

                TotalResets = PlayerPrefs.GetInt("LTotalResets");
                PlayerPrefs.SetInt("LTotalResets", TotalResets + 1);

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
            //when dying
            TotalDeaths = PlayerPrefs.GetInt("TotalDeaths");
            PlayerPrefs.SetInt("TotalDeaths", TotalDeaths + 1);

            TotalDeaths = PlayerPrefs.GetInt("LTotalDeaths");
            PlayerPrefs.SetInt("LTotalDeaths", TotalDeaths + 1);

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

    void FinishOne()
    {
        CoinsCollected = 0;
        PlayerPrefs.SetInt("Lvl2Lock", 1);
        NewLvl2 = PlayerPrefs.GetInt("NewLvl2");
        if (NewLvl2 == 0)
        {
            PlayerPrefs.SetInt("NewLvl2", 1);
        }
        print("Level 2 loaded/unlocked");
        SceneManager.LoadScene(2);
    }
    
    void FinishTwo()
    {
        PlayerPrefs.SetInt("Character2Lock", 1);
        PlayerPrefs.SetInt("NewChar2", 1); //char 2 unlocks
        CoinsCollected = 0;
        PlayerPrefs.SetInt("Lvl3Lock", 1);
        NewLvl3 = PlayerPrefs.GetInt("NewLvl3");
        if (NewLvl3 == 0)
        {
            PlayerPrefs.SetInt("NewLvl3", 1);
        }
        print("Level 3 loaded/unlocked");
        SceneManager.LoadScene(3);
    }
    
    void FinishThree()
    {
        CoinsCollected = 0;
        PlayerPrefs.SetInt("Lvl4Lock", 1);
        NewLvl4 = PlayerPrefs.GetInt("NewLvl4");
        if (NewLvl4 == 0)
        {
            PlayerPrefs.SetInt("NewLvl4", 1);
        }
        print("Level 4 loaded/unlocked");
        SceneManager.LoadScene(4);
    }
    
    void FinishFour()
    {
        CoinsCollected = 0;
        PlayerPrefs.SetInt("Lvl5Lock", 1);
        NewLvl5 = PlayerPrefs.GetInt("NewLvl5");
        if (NewLvl5 == 0)
        {
            PlayerPrefs.SetInt("NewLvl5", 1);
        }
        print("Level 5 loaded/unlocked");
        SceneManager.LoadScene(5);
    }
    
    void FinishFive()
    {
        CoinsCollected = 0;
        PlayerPrefs.SetInt("Character3Lock", 1);
        print("Level 5 completed");
        SceneManager.LoadScene(0);
        Lock3 = PlayerPrefs.GetInt("3LockMessage");
        if (Lock3 == 0)
        {
            PlayerPrefs.SetInt("3LockMessage", 1);
        }
        PlayerPrefs.SetInt("NewChar3", 1); //char 3 unlocks
    }

    /*
    sceneNumber = sceneNumber + 1;
    Debug.Log(sceneNumber);
    if (sceneNumber == 6)
    {
        SceneManager.LoadScene(0);
    }
    else
    {
        SceneManager.LoadScene(sceneNumber);
    }
    */
}
