using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CharacterSelection : MonoBehaviour
{
    private int index;
    internal GameObject[] Player;

    private void Awake()
    {
        //sets int to player pref
        index = PlayerPrefs.GetInt("CharacterSelected");

        //sets up array
        Player = new GameObject[transform.childCount];

        for (int i = 0; i + 1 <= transform.childCount; i++)
        {
            Player[i] = transform.GetChild(i).gameObject;
            print("Initializing " + (i + 1) + " of " + transform.childCount); //debug for player array setup
        }

        //disables all children
        foreach (GameObject obj in Player)
            obj.SetActive(false);

        //enables active child based on the "CharacterSelected" int
        if (Player[index - 1])
        {
            Player[index - 1].SetActive(true);
            print("Character " + index + " active");
        }
    }
}
