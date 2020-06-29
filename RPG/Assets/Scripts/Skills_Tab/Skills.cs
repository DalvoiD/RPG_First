using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Skills : MonoBehaviour, IPointerClickHandler
{
    private GameObject SkillsRef;

    public bool skillsOpened = false;

    void Start()
    {
        SkillsRef = GameObject.Find("Skills");
        SkillsRef.SetActive(false);
    }

    void Update()
    {
        if (Input.GetKeyUp(KeyCode.S))
        {
            if (!skillsOpened)
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
        if (!skillsOpened)
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
        SkillsRef.SetActive(true);
        skillsOpened = true;
    }

    public void CloseInvetory()
    {
        SkillsRef.SetActive(false);
        skillsOpened = false;
    }
}
