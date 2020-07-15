using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConverterManager : MonoBehaviour
{
    const int MAXTEXT = 30;
    public string currentText;
    public BaseButton[] baseButton = new BaseButton[10]; //base Button 0 is base converter, base Button 1 is converted
    public TextView textView;
    bool isPerform;

    //two Button being chosed
    [HideInInspector]
    public int firstIndex, secondIndex;



    private void Start()
    {
        firstIndex = secondIndex = -1;
        isPerform = false;
    }
    public void AddKey(string key)
    {
        if (isPerform == true)
        {
            isPerform = false;
            ResetTextview();
        }
        if (currentText.Length + key.Length < MAXTEXT)
        {
            currentText += key;
        }
    }

    public void DelKey()
    {
        if (isPerform == true)
        {
            isPerform = false;
            ResetTextview();
        }
        if (currentText.Length > 0)
        {
            currentText = currentText.Remove(currentText.Length - 1, 1);
            if((currentText.Length > 0) && (currentText[currentText.Length - 1] == ' ')) currentText = currentText.Remove(currentText.Length - 1, 1);
        }
    }

    public void Convert(double number)
    {
        baseButton[0].money.text = number.ToString();
        baseButton[1].money.text = (number * baseButton[0].dollarValue / baseButton[1].dollarValue).ToString();
    }

    public void ResetConverter()
    {
        baseButton[0].money.text = "";
        baseButton[1].money.text = "";
    }

    public void ResetTextview()
    {
        currentText = "";
    }
    public void Perform()
    {
        if (currentText == "") return;
        ResetConverter();
        isPerform = true;
        StringPreprocess();
        double result = 0;
        string[] strList = currentText.Split(char.Parse(" "));

        if (BadPerformanceCheck(strList))
        {
            currentText = "Bad Performance!!!";
            return;
        }
        result = Calculate(strList);
        if (result < 0)
        {
            currentText = "Bad Performance";
            return;
        }
        Convert(result);

    }

    double Calculate(string[] strList)
    {
        for (int i = 1;i < strList.Length - 1;i += 2)
        {
            if(strList[i][0] == 'X')
            {
                double x = double.Parse(strList[i - 1]) * double.Parse(strList[i + 1]);
                strList[i - 1] = (double.Parse(strList[i - 1]) * double.Parse(strList[i + 1])).ToString();
                strList[i] = "+";
                strList[i + 1] = "0";
            }

            if (strList[i][0] == '/')
            {
                strList[i - 1] = (double.Parse(strList[i - 1]) / double.Parse(strList[i + 1])).ToString();
                strList[i] = "+";
                strList[i + 1] = "0";
            }
        }
        double res = 0;
        res = double.Parse(strList[0]);
        for (int i = 1; i < strList.Length - 1; i += 2)
        {
            if (strList[i][0] == '+')
                res += double.Parse(strList[i + 1]);
            if (strList[i][0] == '-')
                res -= double.Parse(strList[i + 1]);
        }
        return res;
    }

    void StringPreprocess()
    {
        if (currentText[0] == ' ') currentText = currentText.Remove(0, 1);
        if (currentText[currentText.Length - 1] == ' ') currentText = currentText.Remove(currentText.Length - 1, 1);
    }
    bool OperatorChecking(string key)
    {
        char[] operation = { '+', '-','X', '/'};
        foreach (char x in operation)
            if (key[0] == x) return true;
        return false;
    }

    bool BadPerformanceCheck(string[] strList)
    {
        if (OperatorChecking(strList[0]) || OperatorChecking(strList[strList.Length - 1])) return true;
        
        for (int i = 0; i < strList.Length - 1; i++)
        {
            if(OperatorChecking(strList[i]) && OperatorChecking(strList[i + 1])) return true;
        }
        
        foreach(string s in strList)
        {
            int cnt = 0;
            if(!OperatorChecking(s))
            {
                for (int i = 0; i < s.Length; i++)
                    if (s[i] == '.') ++cnt;
                if (cnt > 1) return true;
            }
        }

        for (int i = 0; i < strList.Length - 1; i++)
        {
            if (OperatorChecking(strList[i]) && (strList[i][0] == '/') && (float.Parse(strList[i + 1]) == 0f)) return true;
        }

        return false;
    }

    public void Update()
    {
        textView.SetText(currentText);    
    }

}
