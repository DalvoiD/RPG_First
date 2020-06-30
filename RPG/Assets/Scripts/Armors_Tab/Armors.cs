using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Armors : MonoBehaviour, IPointerClickHandler
{
    private GameObject ArmorsRef;

    public bool armorsOpened = false;

    void Start()
    {
        ArmorsRef = GameObject.Find("Armors");
        ArmorsRef.SetActive(false); 
    }

    void Update()
    {
        if (Input.GetKeyUp(KeyCode.R))
        {
            if (!armorsOpened)
            {
                OpenInvetory();
            }
            else
            {
                CloseInvetory();
            }
        }
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        if (!armorsOpened)
        {
            OpenInvetory();
        }
        else
        {
            CloseInvetory();
        }
    }

    public void OpenInvetory()
    {
        ArmorsRef.SetActive(true);
        armorsOpened = true;
    }

    public void CloseInvetory()
    {
        ArmorsRef.SetActive(false);
        armorsOpened = false;
    }
}