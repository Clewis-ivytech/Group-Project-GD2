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
    [SerializeField] GameObject DevObj;
    [HideInInspector] public bool DevMode;
    [SerializeField] TMP_Text DevTxt;
    private int DevPref;
    private int boolean;
    [SerializeField] GameObject QuitConfirm;
    [SerializeField] GameObject ResetConfirm;
    [SerializeField] GameObject UnlockTxt;
    private float timeToAppear = 4f;
    private float timeWhenDisappear;
    private int Lock3;
    [SerializeField] GameObject StatsScreen;
    [SerializeField] TMP_Text CoinsTxt;
    [SerializeField] TMP_Text DeathsTxt;
    [SerializeField] TMP_Text JumpsTxt;
    [SerializeField] TMP_Text ResetsTxt;
    private int TotalCoins;
    private int TotalDeaths;
    private int TotalJumps;
    private int TotalResets;
    [SerializeField] TMP_Text LCoinsTxt;
    [SerializeField] TMP_Text LDeathsTxt;
    [SerializeField] TMP_Text LJumpsTxt;
    [SerializeField] TMP_Text LResetsTxt;
    private int LTotalCoins;
    private int LTotalDeaths;
    private int LTotalJumps;
    private int LTotalResets;
    private AudioManager Audio;
    private int mute;
    public bool muted;
    [SerializeField] GameObject muteCheck;
    [SerializeField] AudioManager manager;

    private void Awake()
    {
        Audio = FindObjectOfType<AudioManager>();

        mute = PlayerPrefs.GetInt("Mute");
        if (mute == 1)
        {
            muted = true;
            muteCheck.SetActive(true);
        }
        else
        {
            muted = false;
            muteCheck.SetActive(false);
        }

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

        Lock3 = PlayerPrefs.GetInt("3LockMessage");
        if (Lock3 == 1)
        {
            PlayerPrefs.SetInt("3LockMessage", 2);
            UnlockTxt.SetActive(true);
            timeWhenDisappear = Time.time + timeToAppear;
        }

        DevPref = PlayerPrefs.GetInt("DevMode");
        if (DevPref == 1)
        {
            DevObj.SetActive(true);
        }
    }

    private void Update()
    {
        if (UnlockTxt.activeSelf == true && (Time.time >= timeWhenDisappear))
        {
            UnlockTxt.SetActive(false);
        }
    }

    public void LoadLevelOne()
    {
        SceneManager.LoadScene(1);
        Audio.Play("Click");
    }

    public void LoadLevelTwo()
    {
        if (Lvl2Lock || DevMode)
        {
            SceneManager.LoadScene(2);
            Audio.Play("Click");
        }
    }

    public void LoadLevelThree()
    {
        if (Lvl3Lock || DevMode)
        {
            SceneManager.LoadScene(3);
            Audio.Play("Click");
        }
    }

    public void LoadLevelFour()
    {
        if (Lvl4Lock || DevMode)
        {
            SceneManager.LoadScene(4);
            Audio.Play("Click");
        }
    }

    public void LoadLevelFive()
    {
        if (Lvl5Lock || DevMode)
        {
            SceneManager.LoadScene(5);
            Audio.Play("Click");
        }
    }

    public void LevelPanalOn()
    {
        LevelPanal.SetActive(true);
        MainMenuPanal.SetActive(false);
        CharacterDiaplay.SetActive(false);
        Audio.Play("Click");

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
        Audio.Play("Click");
    }

    public void SettingsPanelOn()
    {
        SettingsPanal.SetActive(true);
        MainMenuPanal.SetActive(false);
        CharacterDiaplay.SetActive(false);
        Audio.Play("Click");
    }

    public void SettingsPanelOff()
    {
        MainMenuPanal.SetActive(true);
        SettingsPanal.SetActive(false);
        CharacterDiaplay.SetActive(true);
        Audio.Play("Click");
        Audio.Play("Click");
    }

    public void CreditsOn()
    {
        SettingsPanal.SetActive(false);
        Credits.SetActive(true);
        Audio.Play("Click");
    }

    public void CreditsOff()
    {
        SettingsPanal.SetActive(true);
        Credits.SetActive(false);
        Audio.Play("Click");
    }

    public void CharacterPanelOn()
    {
        CharacterPanal.SetActive(true);
        MainMenuPanal.SetActive(false);
        Spotlight.SetActive(true);
        Audio.Play("Click");

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
        Audio.Play("Click");
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
        Audio.Play("Click");

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
            Audio.Play("Click");

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
            Audio.Play("Click");

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
            Audio.Play("Click");
        }
        else
        {
            DevMode = true;
            DevTxt.SetText("Dev Mode*");
            Audio.Play("Click");
        }
    }

    public void OpenQuitConfirm()
    {
        QuitConfirm.SetActive(true);
        Audio.Play("Click");
    }

    public void CloseQuitConfirm()
    {
        QuitConfirm.SetActive(false);
        Audio.Play("Click");
    }

    public void QuitGame()
    {
#if UNITY_EDITOR
        QuitConfirm.SetActive(false);
        UnityEditor.EditorApplication.isPlaying = false;
        Debug.Log("Game is exiting");
#else
      QuitConfirm.SetActive(false);
      Application.Quit();
      Debug.Log("Game is exiting");
#endif
    }

    public void OpenResetConfirm()
    {
        ResetConfirm.SetActive(true);
        Audio.Play("Click");
    }

    public void CloseResetConfirm()
    {
        ResetConfirm.SetActive(false);
        Audio.Play("Click");
    }

    public void ResetProgress()
    {
        ResetConfirm.SetActive(false);
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
        PlayerPrefs.SetInt("2LockMessage", 0);
        PlayerPrefs.SetInt("3LockMessage", 0);
        PlayerPrefs.SetInt("NewLvl2", 0);
        PlayerPrefs.SetInt("NewLvl3", 0);
        PlayerPrefs.SetInt("NewLvl4", 0);
        PlayerPrefs.SetInt("NewLvl5", 0);
        PlayerPrefs.SetInt("NewChar2", 0);
        PlayerPrefs.SetInt("NewChar3", 0);
        PlayerPrefs.SetInt("TotalCoins", 0);
        PlayerPrefs.SetInt("TotalDeaths", 0);
        PlayerPrefs.SetInt("TotalJumps", 0);
        PlayerPrefs.SetInt("TotalResets", 0);

        Awake();
    }

    public void OpenStats()
    {
        StatsScreen.SetActive(true);
        MainMenuPanal.SetActive(false);
        Audio.Play("Click");

        TotalCoins = PlayerPrefs.GetInt("TotalCoins");
        CoinsTxt.SetText("Coins Collected: " + TotalCoins);
        TotalDeaths = PlayerPrefs.GetInt("TotalDeaths");
        DeathsTxt.SetText("Total Deaths: " + TotalDeaths);
        TotalJumps = PlayerPrefs.GetInt("TotalJumps");
        JumpsTxt.SetText("Total Jumps: " + TotalJumps);
        TotalResets = PlayerPrefs.GetInt("TotalResets");
        ResetsTxt.SetText("Total Resets: " + TotalResets);

        LTotalCoins = PlayerPrefs.GetInt("LTotalCoins");
        LCoinsTxt.SetText("Coins Collected: " + LTotalCoins);
        LTotalDeaths = PlayerPrefs.GetInt("LTotalDeaths");
        LDeathsTxt.SetText("Total Deaths: " + LTotalDeaths);
        LTotalJumps = PlayerPrefs.GetInt("LTotalJumps");
        LJumpsTxt.SetText("Total Jumps: " + LTotalJumps);
        LTotalResets = PlayerPrefs.GetInt("LTotalResets");
        LResetsTxt.SetText("Total Resets: " + LTotalResets);
    }

    public void CloseStats()
    {
        StatsScreen.SetActive(false);
        MainMenuPanal.SetActive(true);
        Audio.Play("Click");
    }

    public void MuteToggle()
    {
        if (muted)
        {
            muted = false;
            muteCheck.SetActive(false);
            PlayerPrefs.SetInt("Mute", 0);
            Audio.Play("Click");
        }
        else
        {
            muted = true;
            muteCheck.SetActive(true);
            PlayerPrefs.SetInt("Mute", 1);
            Audio.Play("Click");
        }
    }

}
