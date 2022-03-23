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
        CharacterPanal.SetActive(true);
        SettingsPanal.SetActive(false);
    }

}
