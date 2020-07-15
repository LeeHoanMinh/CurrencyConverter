using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NumButton : MonoBehaviour
{
    public string buttonName;
    public string buttonTag;
    Text displayName;
    EventController eventController;
    public void OnClick()
    {
        eventController.NumbuttonReceiver(buttonName,buttonTag);            
    }

    void Start()
    {
        displayName = transform.GetChild(0).GetComponent<Text>();
        eventController = GameObject.Find("EventController").GetComponent<EventController>();
    }
    void Update()
    {
        //displayName.text = buttonName;        
    }
}
