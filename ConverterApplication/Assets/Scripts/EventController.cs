using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventController:MonoBehaviour
{
    public ConverterManager converterManager;
    public Tab2Manager tab2Manager;
    public void NumbuttonReceiver(string buttonName,string buttonTag)
    { 
        if (buttonTag == "Perform") converterManager.Perform();
        if (buttonTag == "Operate") converterManager.AddKey(" " + buttonName + " ");
        if (buttonTag == "Delete") converterManager.DelKey();
        if (buttonTag == "Number") converterManager.AddKey(buttonName);
        BaseButtonReceiver(-1);
    }

    public void BaseButtonReceiver(int viewIndex)
    {
        int temp1 = converterManager.firstIndex;
        int temp2 = converterManager.secondIndex;
        if (viewIndex == -1) temp1 = temp2 = -1;
        else
        if (temp1 == -1) temp1 = viewIndex;
        else if(temp2 == -1)
        {
            temp2 = viewIndex;
            converterManager.baseButton[temp1].SwapButton(converterManager.baseButton[temp2]);
            temp1 = temp2 = -1;
            converterManager.ResetConverter();
        }

        converterManager.firstIndex = temp1;
        converterManager.secondIndex = temp2;
    }

    public void BaseButtonOnTab2Receiver(int viewIndex)
    {
        BaseButton button = tab2Manager.baseButtonTab2[viewIndex];
        converterManager.AddNewBase(button);
        tab2Manager.DeleteButton(viewIndex);
    }
}
