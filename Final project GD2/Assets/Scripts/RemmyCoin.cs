using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemmyCoin : MonoBehaviour
{
    // public int ID;
    // public int LevelID;
    private bool Collected = false;
    [SerializeField] RemmyCoin Instance;
    [SerializeField] GameObject remmyCoin;
    [SerializeField] Rigidbody remmyCoinRB;
    [SerializeField] LevelUIManager LevelUIManager;
    private int TotalCoins;

    private void Awake()
    {
        Collected = false;
    }
    private void Update()
    {
        if(Collected)
        {
           remmyCoin.SetActive(false);
        }

    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Character"))
        {
            LevelUIManager.RemmyCoinCollected = LevelUIManager.RemmyCoinCollected + 1;
            Collected = true;

            //when getting a coin
            TotalCoins = PlayerPrefs.GetInt("TotalCoins");
            PlayerPrefs.SetInt("TotalCoins", TotalCoins + 1);

            TotalCoins = PlayerPrefs.GetInt("LTotalCoins");
            PlayerPrefs.SetInt("LTotalCoins", TotalCoins + 1);
        }
    }

}
