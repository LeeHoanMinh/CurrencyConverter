using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventController:MonoBehaviour
{
    public ConverterManager converterManager;
        public void NumbuttonReceiver(string buttonName,string buttonTag)
        {
            if (buttonTag == "Perform") converterManager.Perform();
            if (buttonName == "Operate") converterManager.AddKey(buttonName);
            if (buttonName == "Delete") converterManager.DelKey();
            if (buttonName == "Number") converterManager.AddKey(buttonName);
        }
}
