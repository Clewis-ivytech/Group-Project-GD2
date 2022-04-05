using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewUnlocks : MonoBehaviour
{
    public bool NewLvl2;
    public bool NewLvl3;
    public bool NewLvl4;
    public bool NewLvl5;
    public bool NewChar2;
    public bool NewChar3;
    [SerializeField] GameObject MainNewLvl;
    [SerializeField] GameObject MainNewChar;
    [SerializeField] GameObject Lvl2;
    [SerializeField] GameObject Lvl3;
    [SerializeField] GameObject Lvl4;
    [SerializeField] GameObject Lvl5;
    [SerializeField] GameObject Char2;
    [SerializeField] GameObject Char3;
    private int New;

    void Start()
    {
        
    }

    void Update()
    {
        New = PlayerPrefs.GetInt("NewLvl2");
        if (New == 1)
        {
            NewLvl2 = true;
        }
        else
        {
            NewLvl2 = false;
        }

        New = PlayerPrefs.GetInt("NewLvl3");
        if (New == 1)
        {
            NewLvl3 = true;
        }
        else
        {
            NewLvl3 = false;
        }
        New = PlayerPrefs.GetInt("NewLvl4");
        if (New == 1)
        {
            NewLvl4 = true;
        }
        else
        {
            NewLvl4 = false;
        }
        New = PlayerPrefs.GetInt("NewLvl5");
        if (New == 1)
        {
            NewLvl5 = true;
        }
        else
        {
            NewLvl5 = false;
        }
        New = PlayerPrefs.GetInt("NewChar2");
        if (New == 1)
        {
            NewChar2 = true;
        }
        else
        {
            NewChar2 = false;
        }
        New = PlayerPrefs.GetInt("NewChar3");
        if (New == 1)
        {
            NewChar3 = true;
        }
        else
        {
            NewChar3 = false;
        }

        if (NewLvl2 | NewLvl3 | NewLvl4 | NewLvl5)
        {
            MainNewLvl.SetActive(true);
        }
        else
        {
            MainNewLvl.SetActive(false);
        }

        if (NewChar2 || NewChar3)
        {
            MainNewChar.SetActive(true);
        }
        else
        {
            MainNewChar.SetActive(false);
        }

        if (NewLvl2)
        {
            Lvl2.SetActive(true);
        }
        else
        {
            Lvl2.SetActive(false);
        }

        if (NewLvl3)
        {
            Lvl3.SetActive(true);
        }
        else
        {
            Lvl3.SetActive(false);
        }

        if (NewLvl4)
        {
            Lvl4.SetActive(true);
        }
        else
        {
            Lvl4.SetActive(false);
        }

        if (NewLvl5)
        {
            Lvl5.SetActive(true);
        }
        else
        {
            Lvl5.SetActive(false);
        }

        if (NewChar2)
        {
            Char2.SetActive(true);
        }
        else
        {
            Char2.SetActive(false);
        }

        if (NewChar3)
        {
            Char3.SetActive(true);
        }
        else
        {
            Char3.SetActive(false);
        }
    }
}
