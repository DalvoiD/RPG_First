using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{
    private GameObject InventoryRef;
    public ButtomInfo buttonI;

    public bool inventoryOpened = false;

    void Start()
    {
        InventoryRef = GameObject.Find("Inventory");
        InventoryRef.SetActive(false);
    }

    void Update()
    {
        if (Input.GetKeyUp(KeyCode.I) || buttonI.isDown)
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
