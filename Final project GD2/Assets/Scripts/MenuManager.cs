using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public GameObject MainMenuPanal;
    public GameObject LevelPanal;
    public GameObject SettingsPanal;
    public GameObject CharacterPanal;

    public GameObject Character1;
    public GameObject Character2;
    public GameObject Character3;
    public float CurrentCharacter;
    public bool Char2Lock;
    public bool Char3Lock;
    public TMP_Text Char2Txt;
    public TMP_Text Char3Txt;

    private void Start()
    {
        CurrentCharacter = 1;
        if (Char2Lock == true)
        {
            Char2Txt.SetText("PlaceHolder");
        }
        else
        {
            Char2Txt.SetText("(Locked)");
        }

        if (Char3Lock == true)
        {
            Char3Txt.SetText("PlaceHolder");
        }
        else
        {
            Char3Txt.SetText("(Locked)");
        }
    }

    public void LoadLevelOne()
    {
        SceneManager.LoadScene(1);
    }

    public void LoadLevelTwo()
    {
        SceneManager.LoadScene(2);
    }

    public void LoadLevelThree()
    {
        SceneManager.LoadScene(3);
    }

    public void LoadLevelFour()
    {
        SceneManager.LoadScene(4);
    }

    public void LoadLevelFive()
    {
        SceneManager.LoadScene(5);
    }

    public void LevelPanalOn()
    {
        LevelPanal.SetActive(true);
        MainMenuPanal.SetActive(false);
    }

    public void LevelPanalOff()
    {
        MainMenuPanal.SetActive(true);
        LevelPanal.SetActive(false);
    }

    public void SettingsPanelOn()
    {
        SettingsPanal.SetActive(true);
        MainMenuPanal.SetActive(false);
    }

    public void SettingsPanelOff()
    {
        MainMenuPanal.SetActive(true);
        SettingsPanal.SetActive(false);
    }

    public void CharacterPanelOn()
    {
        CharacterPanal.SetActive(true);
        MainMenuPanal.SetActive(false);
    }

    public void CharacterPanelOff()
    {
        CharacterPanal.SetActive(false);
        MainMenuPanal.SetActive(true);
    }

    public void CharacterOne()
    {
        Character1.SetActive(true);
        Character2.SetActive(false);
        Character3.SetActive(false);
        CurrentCharacter = 1;
    }

    public void CharacterTwo()
    {
        if (Char2Lock == true)
        {
            Character1.SetActive(false);
            Character2.SetActive(true);
            Character3.SetActive(false);
            CurrentCharacter = 2;
        }
        else
        {
            Char2Txt.SetText("(Locked)");
        }
    }

    public void CharacterThree()
    {
        if (Char3Lock == true)
        {
            Character1.SetActive(false);
            Character2.SetActive(false);
            Character3.SetActive(true);
            CurrentCharacter = 3;
        }
        else
        {
            Char3Txt.SetText("(Locked)");
        }
    }
}
