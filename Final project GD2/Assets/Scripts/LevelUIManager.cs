using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
public class LevelUIManager : MonoBehaviour
{
    /*[HideInInspector]*/ public int RemmyCoinCollected;
    [SerializeField] TextMeshProUGUI RemmyCount;
    [SerializeField] Player PlayerScript;
    [SerializeField] GameObject UnlockTxt;
    private float timeToAppear = 4f;
    private float timeWhenDisappear;
    private int Lock2;
    private AudioManager Audio;

    private void Start()
    {
        Audio = FindObjectOfType<AudioManager>();
        Lock2 = PlayerPrefs.GetInt("2LockMessage");
        if (UnlockTxt == null)
        {
            return;
        }
        else if (Lock2 == 0)
        {
            PlayerPrefs.SetInt("2LockMessage", 1);
            UnlockTxt.SetActive(true);
            timeWhenDisappear = Time.time + timeToAppear;
        }
    }

    public void LoadMenu()
    {
        Audio.Play("Click");
        SceneManager.LoadScene(0);
    }

    private void Update()
    {
        RemmyCount.text = "Coins: " + RemmyCoinCollected + "/5";

        if (RemmyCoinCollected == 5)
        {
            PlayerScript.CoinsCollected = 5;
        }

        if (UnlockTxt == null)
        {
            return;
        }
        else if(UnlockTxt.activeSelf == true && (Time.time >= timeWhenDisappear))
        {
            UnlockTxt.SetActive(false);
        }
    }
}
