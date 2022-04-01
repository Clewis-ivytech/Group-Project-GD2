using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class EventTrigger : MonoBehaviour, IPointerEnterHandler
{
    [SerializeField] GameObject Image;
    [SerializeField] GameObject Image2;
    [SerializeField] GameObject Image3;
    [SerializeField] GameObject Image4;
    [SerializeField] GameObject Image5;
    [SerializeField] MenuManager MenuManagerScript;
    [SerializeField] bool Lvl2;
    [SerializeField] bool Lvl3;
    [SerializeField] bool Lvl4;
    [SerializeField] bool Lvl5;

    public void OnPointerEnter(PointerEventData data)
    {
        if (Lvl5 && (MenuManagerScript.Lvl5Lock || MenuManagerScript.DevMode))
        {
            Image5.SetActive(true);
            Image4.SetActive(false);
            Image3.SetActive(false);
            Image2.SetActive(false);
            Image.SetActive(false);
        }
        else if (Lvl4 && (MenuManagerScript.Lvl4Lock || MenuManagerScript.DevMode))
        {
            Image4.SetActive(true);
            Image5.SetActive(false);
            Image3.SetActive(false);
            Image2.SetActive(false);
            Image.SetActive(false);
        }
        else if (Lvl3 && (MenuManagerScript.Lvl3Lock || MenuManagerScript.DevMode))
        {
            Image3.SetActive(true);
            Image5.SetActive(false);
            Image4.SetActive(false);
            Image2.SetActive(false);
            Image.SetActive(false);
        }
        else if (Lvl2 && (MenuManagerScript.Lvl2Lock || MenuManagerScript.DevMode))
        {
            Image2.SetActive(true);
            Image5.SetActive(false);
            Image4.SetActive(false);
            Image3.SetActive(false);
            Image.SetActive(false);
        }
        else
        {
            Image.SetActive(true);
            Image5.SetActive(false);
            Image4.SetActive(false);
            Image3.SetActive(false);
            Image2.SetActive(false);
        }
    }

    public void ResetPreviews()
    {
        Image.SetActive(false);
        Image2.SetActive(false);
        Image3.SetActive(false);
        Image4.SetActive(false);
        Image5.SetActive(false);
    }
}
