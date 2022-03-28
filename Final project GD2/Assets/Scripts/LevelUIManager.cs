using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
public class LevelUIManager : MonoBehaviour
{
    [HideInInspector] public int RemmyCoinCollected;
    [SerializeField] TextMeshProUGUI RemmyCount;
    [SerializeField] Player PlayerScript;

    public void LoadMenu()
    {
        SceneManager.LoadScene(0);
    }

    private void Update()
    {
        RemmyCount.text = "Coins: " + RemmyCoinCollected + "/5";

        if (RemmyCoinCollected == 5)
        {
            PlayerScript.CoinsCollected = 5;
        }
    }
}
