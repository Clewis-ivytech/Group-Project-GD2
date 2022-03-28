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
    private MenuManager MenuManagerScript;
    [SerializeField] bool Lvl2;
    [SerializeField] bool Lvl3;
    [SerializeField] bool Lvl4;
    [SerializeField] bool Lvl5;
    private bool Lvl2Lock;
    private bool Lvl3Lock;
    private bool Lvl4Lock;
    private bool Lvl5Lock;

    public void OnPointerEnter(PointerEventData data)
    {
        if (Lvl5) //&& Lvl5Lock)
        {
            Image5.SetActive(true);
            Image4.SetActive(false);
            Image3.SetActive(false);
            Image2.SetActive(false);
            Image.SetActive(false);
        }
        else if (Lvl4) //&& Lvl4Lock)
        {
            Image4.SetActive(true);
            Image5.SetActive(false);
            Image3.SetActive(false);
            Image2.SetActive(false);
            Image.SetActive(false);
        }
        else if (Lvl3) //&& Lvl3Lock)
        {
            Image3.SetActive(true);
            Image5.SetActive(false);
            Image4.SetActive(false);
            Image2.SetActive(false);
            Image.SetActive(false);
        }
        else if (Lvl2) //&& Lvl2Lock)
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
}
