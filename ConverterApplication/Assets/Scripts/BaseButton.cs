using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BaseButton : MonoBehaviour
{
    string baseName;
    Image baseFlag;
    public float dollarValue;
    EventController eventController;
    public void Start()
    {
        eventController = GameObject.Find("EventController").GetComponent<EventController>();
    }
    public void SwapButton()
    {

    }
}
