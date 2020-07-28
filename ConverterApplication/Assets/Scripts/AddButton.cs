using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddButton : MonoBehaviour
{
    ConverterManager converterManager;

    private void Start()
    {
        converterManager = GameObject.Find("ConverterManager").GetComponent<ConverterManager>();
    }
    public void ClickOn()
    {
        converterManager.ChangeFromTab1ToTab2();
    }
}
