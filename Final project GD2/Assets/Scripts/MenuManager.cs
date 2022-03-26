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
    public GameObject Credits;

    public GameObject CharacterDiaplay;
    public GameObject Spotlight;
    public GameObject Character1;
    public GameObject Character2;
    public GameObject Character3;
    public GameObject Character1Txt;
    public GameObject Character2Txt;
    public GameObject Character3Txt;
    public float CurrentCharacter;
    public bool Char2Lock;
    public bool Char3Lock;
    public TMP_Text Char2Txt;
    public TMP_Text Char3Txt;

    private void Start()
    {
        CurrentCharacter = 1;
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
        CharacterDiaplay.SetActive(false);
    }

    public void LevelPanalOff()
    {
        MainMenuPanal.SetActive(true);
        LevelPanal.SetActive(false);
        CharacterDiaplay.SetActive(true);
    }

    public void SettingsPanelOn()
    {
        SettingsPanal.SetActive(true);
        MainMenuPanal.SetActive(false);
        CharacterDiaplay.SetActive(false);
    }

    public void SettingsPanelOff()
    {
        MainMenuPanal.SetActive(true);
        SettingsPanal.SetActive(false);
        CharacterDiaplay.SetActive(true);
    }

    public void CreditsOn()
    {
        SettingsPanal.SetActive(false);
        Credits.SetActive(true);
    }

    public void CreditsOff()
    {
        SettingsPanal.SetActive(true);
        Credits.SetActive(false);
    }

    public void CharacterPanelOn()
    {
        CharacterPanal.SetActive(true);
        MainMenuPanal.SetActive(false);
        Spotlight.SetActive(true);

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
            Char3Txt.SetText("Colin Christ");
        }
        else
        {
            Char3Txt.SetText("(Locked)");
        }
    }

    public void CharacterPanelOff()
    {
        CharacterPanal.SetActive(false);
        MainMenuPanal.SetActive(true);
        Spotlight.SetActive(false);
    }

    public void CharacterOne()
    {
        Character1.SetActive(true);
        Character2.SetActive(false);
        Character3.SetActive(false);
        Character1Txt.SetActive(true);
        Character2Txt.SetActive(false);
        Character3Txt.SetActive(false);
        CurrentCharacter = 1;
    }

    public void CharacterTwo()
    {
        if (Char2Lock == true)
        {
            Character1.SetActive(false);
            Character2.SetActive(true);
            Character3.SetActive(false);
            Character1Txt.SetActive(false);
            Character2Txt.SetActive(true);
            Character3Txt.SetActive(false);
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
            Character1Txt.SetActive(false);
            Character2Txt.SetActive(false);
            Character3Txt.SetActive(true);
            CurrentCharacter = 3;
        }
        else
        {
            Char3Txt.SetText("(Locked)");
        }
    }
}
