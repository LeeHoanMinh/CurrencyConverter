using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextView : MonoBehaviour
{
    string viewText;
    void Update()
    {
        transform.GetComponent<Text>().text = viewText;    
    }

    public void SetText(string text)
    {
        viewText = text;
    }
}
