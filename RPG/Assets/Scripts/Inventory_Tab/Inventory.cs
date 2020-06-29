using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Inventory : MonoBehaviour, IPointerClickHandler
{
    private GameObject InventoryRef;

    public bool inventoryOpened = false;

    void Start()
    {
        InventoryRef = GameObject.Find("Inventory");
        InventoryRef.SetActive(false);
    }

    void Update()
    {
        if (Input.GetKeyUp(KeyCode.I))
        {
            if (!inventoryOpened)
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
        if (!inventoryOpened)
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
        InventoryRef.SetActive(true);
        inventoryOpened = true;
    }

    public void CloseInvetory()
    {
        InventoryRef.SetActive(false);
        inventoryOpened = false;
    }
}
