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
    [SerializeField] bool Char2Lock;
    [SerializeField] bool Char3Lock;
    [SerializeField] TMP_Text Char2Txt;
    [SerializeField] TMP_Text Char3Txt;
    [SerializeField] TMP_Text Lvl2Txt;
    [SerializeField] TMP_Text Lvl3Txt;
    [SerializeField] TMP_Text Lvl4Txt;
    [SerializeField] TMP_Text Lvl5Txt;
    [HideInInspector] public bool Lvl2Lock;
    [HideInInspector] public bool Lvl3Lock;
    [HideInInspector] public bool Lvl4Lock;
    [HideInInspector] public bool Lvl5Lock;
    private int index;
    [SerializeField] bool Dev;
    [SerializeField] GameObject DevObj;
    [HideInInspector] public bool DevMode;
    [SerializeField] TMP_Text DevTxt;
    private int boolean;

    private void Awake()
    {
        boolean = PlayerPrefs.GetInt("Lvl2Lock");
        if (boolean == 1)
        {
            Lvl2Lock = true;
        }
        else
        {
            Lvl2Lock = false;
        }

        boolean = PlayerPrefs.GetInt("Lvl3Lock");
        if (boolean == 1)
        {
            Lvl3Lock = true;
        }
        else
        {
            Lvl3Lock = false;
        }

        boolean = PlayerPrefs.GetInt("Lvl4Lock");
        if (boolean == 1)
        {
            Lvl4Lock = true;
        }
        else
        {
            Lvl4Lock = false;
        }

        boolean = PlayerPrefs.GetInt("Lvl5Lock");
        if (boolean == 1)
        {
            Lvl5Lock = true;
        }
        else
        {
            Lvl5Lock = false;
        }

        boolean = PlayerPrefs.GetInt("Character2Lock");
        if (boolean == 1)
        {
            Char2Lock = true;
        }
        else
        {
            Char2Lock = false;
        }

        boolean = PlayerPrefs.GetInt("Character3Lock");
        if (boolean == 1)
        {
            Char3Lock = true;
        }
        else
        {
            Char3Lock = false;
        }
        
        if (Dev)
        {
            DevObj.SetActive(true);
        }

        index = PlayerPrefs.GetInt("CharacterSelected");

        if (index == 1)
        {
            CharacterOne();
        }

        if (index == 2)
        {
            CharacterTwo();
        }

        if (index == 3)
        {
            CharacterThree();
        }
    }

    public void LoadLevelOne()
    {
        SceneManager.LoadScene(1);
    }

    public void LoadLevelTwo()
    {
        if (Lvl2Lock || DevMode)
        {
            SceneManager.LoadScene(2);
        }
    }

    public void LoadLevelThree()
    {
        if (Lvl3Lock || DevMode)
        {
            SceneManager.LoadScene(3);
        }
    }

    public void LoadLevelFour()
    {
        if (Lvl4Lock || DevMode)
        {
            SceneManager.LoadScene(4);
        }
    }

    public void LoadLevelFive()
    {
        if (Lvl5Lock || DevMode)
        {
            SceneManager.LoadScene(5);
        }
    }

    public void LevelPanalOn()
    {
        LevelPanal.SetActive(true);
        MainMenuPanal.SetActive(false);
        CharacterDiaplay.SetActive(false);

        if (Lvl2Lock || DevMode)
        {
            Lvl2Txt.SetText("Level 2");
        }
        else
        {
            Lvl2Txt.SetText("(Locked)");
        }

        if (Lvl3Lock || DevMode)
        {
            Lvl3Txt.SetText("Level 3");
        }
        else
        {
            Lvl3Txt.SetText("(Locked)");
        }

        if (Lvl4Lock || DevMode)
        {
            Lvl4Txt.SetText("Level 4");
        }
        else
        {
            Lvl4Txt.SetText("(Locked)");
        }

        if (Lvl5Lock || DevMode)
        {
            Lvl5Txt.SetText("Level 5");
        }
        else
        {
            Lvl5Txt.SetText("(Locked)");
        }
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

        if (Char2Lock || DevMode)
        {
            Char2Txt.SetText("PlaceHolder");
        }
        else
        {
            Char2Txt.SetText("(Locked)");
        }

        if (Char3Lock || DevMode)
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
        PlayerPrefs.SetInt("CharacterSelected", 1);

        if (Menu)
        {
            PlayerObject1.SetActive(true);
            PlayerObject2.SetActive(false);
            PlayerObject3.SetActive(false);
        }
    }

    public void CharacterTwo()
    {
        if (Char2Lock || DevMode)
        {
            Character1.SetActive(false);
            Character2.SetActive(true);
            Character3.SetActive(false);
            Character1Txt.SetActive(false);
            Character2Txt.SetActive(true);
            Character3Txt.SetActive(false);
            PlayerPrefs.SetInt("CharacterSelected", 2);

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
        if (Char3Lock || DevMode)
        {
            Character1.SetActive(false);
            Character2.SetActive(false);
            Character3.SetActive(true);
            Character1Txt.SetActive(false);
            Character2Txt.SetActive(false);
            Character3Txt.SetActive(true);
            PlayerPrefs.SetInt("CharacterSelected", 3);

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

    public void DevButton()
    {
        if (DevMode)
        {
            DevMode = false;
            DevTxt.SetText("Dev Mode");
        }
        else
        {
            DevMode = true;
            DevTxt.SetText("Dev Mode*");
        }
    }

    public void ResetProgress()
    {
        CharacterOne();
        if (DevMode)
        {
            DevMode = false;
            DevTxt.SetText("Dev Mode");
        }

        PlayerPrefs.SetInt("CharacterSelected", 1);
        PlayerPrefs.SetInt("Lvl2Lock", 0);
        PlayerPrefs.SetInt("Lvl3Lock", 0);
        PlayerPrefs.SetInt("Lvl4Lock", 0);
        PlayerPrefs.SetInt("Lvl5Lock", 0);
        PlayerPrefs.SetInt("Character2Lock", 0);
        PlayerPrefs.SetInt("Character3Lock", 0);

        Awake();
    }
}
