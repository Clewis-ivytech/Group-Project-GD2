using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    [SerializeField] GameObject MainMenuPanal;
    [SerializeField] GameObject LevelPanal;
    [SerializeField] GameObject SettingsPanal;
    [SerializeField] GameObject CharacterPanal;
    [SerializeField] GameObject Credits;

    [SerializeField] GameObject CharacterDiaplay;
    [SerializeField] GameObject Spotlight;
    [SerializeField] GameObject Character1;
    [SerializeField] GameObject Character2;
    [SerializeField] GameObject Character3;
    [SerializeField] GameObject Character1Txt;
    [SerializeField] GameObject Character2Txt;
    [SerializeField] GameObject Character3Txt;
    [SerializeField] bool Menu;
    [SerializeField] GameObject PlayerObject1;
    [SerializeField] GameObject PlayerObject2;
    [SerializeField] GameObject PlayerObject3;
    private float CurrentCharacter;
    [SerializeField] bool Char2Lock;
    [SerializeField] bool Char3Lock;
    [SerializeField] TMP_Text Char2Txt;
    [SerializeField] TMP_Text Char3Txt;
    [SerializeField] TMP_Text Lvl2Txt;
    [SerializeField] TMP_Text Lvl3Txt;
    [SerializeField] TMP_Text Lvl4Txt;
    [SerializeField] TMP_Text Lvl5Txt;
    private bool Lvl2Lock;
    private bool Lvl3Lock;
    private bool Lvl4Lock;
    private bool Lvl5Lock;

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

        if (Char2Lock)
        {
            Char2Txt.SetText("PlaceHolder");
        }
        else
        {
            Char2Txt.SetText("(Locked)");
        }

        if (Char3Lock)
        {
            Char3Txt.SetText("Colin Christ");
        }
        else
        {
            Char3Txt.SetText("(Locked)");
        }

        if (Lvl2Lock)
        {
            Lvl2Txt.SetText("Level 2");
        }
        else
        {
            Lvl2Txt.SetText("(Locked)");
        }

        if (Lvl3Lock)
        {
            Lvl3Txt.SetText("Level 3");
        }
        else
        {
            Lvl3Txt.SetText("(Locked)");
        }

        if (Lvl4Lock)
        {
            Lvl4Txt.SetText("Level 4");
        }
        else
        {
            Lvl4Txt.SetText("(Locked)");
        }

        if (Lvl5Lock)
        {
            Lvl5Txt.SetText("Level 5");
        }
        else
        {
            Lvl5Txt.SetText("(Locked)");
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

        if (Menu)
        {
            PlayerObject1.SetActive(true);
            PlayerObject2.SetActive(false);
            PlayerObject3.SetActive(false);
        }
    }

    public void CharacterTwo()
    {
        if (Char2Lock)
        {
            Character1.SetActive(false);
            Character2.SetActive(true);
            Character3.SetActive(false);
            Character1Txt.SetActive(false);
            Character2Txt.SetActive(true);
            Character3Txt.SetActive(false);
            CurrentCharacter = 2;

            if (Menu)
            {
               PlayerObject2.SetActive(true);
               PlayerObject1.SetActive(false);
               PlayerObject3.SetActive(false);
            }
        }
        else
        {
            Char2Txt.SetText("(Locked)");
        }
    }

    public void CharacterThree()
    {
        if (Char3Lock)
        {
            Character1.SetActive(false);
            Character2.SetActive(false);
            Character3.SetActive(true);
            Character1Txt.SetActive(false);
            Character2Txt.SetActive(false);
            Character3Txt.SetActive(true);
            CurrentCharacter = 3;

            if (Menu)
            {
                PlayerObject3.SetActive(true);
                PlayerObject1.SetActive(false);
                PlayerObject2.SetActive(false);
            }
        }
        else
        {
            Char3Txt.SetText("(Locked)");
        }
    }
}
