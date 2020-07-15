using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextView : MonoBehaviour
{
    string viewText;
    public void SetText(string text)
    {
        viewText = text;
        transform.GetComponent<Text>().text = viewText;
    }
}
