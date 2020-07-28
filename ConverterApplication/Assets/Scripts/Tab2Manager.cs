using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tab2Manager : MonoBehaviour
{
    public int baseButtonCnt;
    public BaseButton[] baseButtonTab2 = new BaseButton[10]; //base Button 0 is base converter, base Button 1 is converted
    ConverterManager converterManager;

    private void Start()
    {
        converterManager = GameObject.Find("ConverterManager").GetComponent<ConverterManager>();
    }

    public void ChangeTab()
    {
        converterManager.ChangeFromTab2ToTab1();
    }

    public void DeleteButton(int index)
    {
        for (int i = index; i < baseButtonCnt - 1;i++)
            baseButtonTab2[i].Attach(baseButtonTab2[i + 1]);
        baseButtonCnt--;    
        baseButtonTab2[baseButtonCnt].gameObject.SetActive(false);
        

    }
}
