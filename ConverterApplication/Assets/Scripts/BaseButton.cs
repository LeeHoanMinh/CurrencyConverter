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
    public double dollarValue;
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
        Swap.DoubleFloat(ref dollarValue, ref otherButton.dollarValue);

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

    public void OnClick_OnTab2()
    {
        eventController.BaseButtonOnTab2Receiver(viewIndex);
    }

    public void Attach(BaseButton button)
    {
        abbre_baseName = button.abbre_baseName;
        baseName = button.baseName;
        isSelect = button.isSelect;
        dollarValue = button.dollarValue;
        baseFlag.sprite = button.baseFlag.sprite;

}
}
