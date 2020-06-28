using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ButtomInfo : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public bool isDown { get; private set; }

    public void OnPointerDown(PointerEventData eventData)
    {
        isDown = false;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        isDown = true;
    }

}
