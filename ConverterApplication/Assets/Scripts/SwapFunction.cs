using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

static public class Swap
{
    static public void SwapString(ref string firstString,ref string secondString)
    {
        string temp = firstString;
        firstString = secondString;
        secondString = temp;
    }

    static public void SwapImage(ref Image firstImage, ref Image secondImage)
    {
        Sprite temp = firstImage.sprite;
        firstImage.sprite = secondImage.sprite;
        secondImage.sprite = temp;
       
    }

    static public void SwapInt(ref int firstInt, ref int secondInt)
    {
        int temp = firstInt;
        firstInt = secondInt;
        secondInt = temp;
    }

    static public void DoubleFloat(ref double firstFloat, ref double secondFloat)
    {
        double temp = firstFloat;
        firstFloat = secondFloat;
        secondFloat = temp;
    }


}
