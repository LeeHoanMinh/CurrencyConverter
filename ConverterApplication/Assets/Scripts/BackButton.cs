using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackButton : MonoBehaviour
{
    Tab2Manager tab2Manager;
    void Start()
    {
        tab2Manager = GameObject.Find("Tab2Manager").GetComponent<Tab2Manager>();
    }
    public void ClickOn()
    {
        tab2Manager.ChangeTab();
    }
}
