using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class HorizontalMimicking : MonoBehaviour
{
    public GameObject VerticalCanvas;

    // Update is called once per frame
    void Start()
    {
       
    }
    void Update()
    {
        CopyComponent(this.gameObject, VerticalCanvas);
    }

    void CopyComponent(GameObject me,GameObject another)
    {
        

    }
}
