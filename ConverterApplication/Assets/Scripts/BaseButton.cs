using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BaseButton : MonoBehaviour
{
    public string abbre_baseName;
    public string baseName;
    public Text abbre_baseNameT, baseNameT, money;
    bool isSelect;
    public Image baseFlag;
    public int viewIndex; // don't swap it
    public float dollarValue;
    EventController eventController;
    public void Start()
    {
        eventController = GameObject.Find("EventController").GetComponent<EventController>();
        isSelect = false;
    }
    

    public void SwapButton(BaseButton otherButton)
    {
        Swap.SwapString(ref abbre_baseName, ref otherButton.abbre_baseName);
        Swap.SwapString(ref baseName, ref otherButton.baseName);
        Swap.SwapImage(ref baseFlag, ref otherButton.baseFlag);
        Swap.SwapFloat(ref dollarValue, ref otherButton.dollarValue);

    }


    public void Update()
    {
        abbre_baseNameT.text = abbre_baseName;
        baseNameT.text = baseName;
    }

    public void OnClick()
    {
        eventController.BaseButtonReceiver(viewIndex);
    }
}
