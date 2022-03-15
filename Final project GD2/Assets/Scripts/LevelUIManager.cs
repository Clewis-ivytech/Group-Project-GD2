using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
public class LevelUIManager : MonoBehaviour
{
    //
    public int RemmyCoinCollected;
    public TextMeshProUGUI RemmyCount;
    //

    public void LoadMenu()
    {
        SceneManager.LoadScene(0);
    }

    private void Update()
    {
        RemmyCount.text = "Remmy Coins: " + RemmyCoinCollected + "/5";
    }
}
