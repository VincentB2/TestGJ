using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DigiCode : MonoBehaviour
{
    public int Entry0;    
    public int Entry1;    
    public int Entry2;    
    public int Entry3;
    public int whichOne;

    public List<int> digit = new List<int>(4);

    void Start()
    {
        digit.Add(0);
        digit.Add(0);
        digit.Add(0);
        digit.Add(0);
    }

    void Update()
    {
        var number0 = GameObject.Find("0").GetComponent<Text>();
        number0.text = digit[0].ToString();

        var number1 = GameObject.Find("1").GetComponent<Text>();
        number1.text = digit[1].ToString();

        var number2 = GameObject.Find("2").GetComponent<Text>();
        number2.text = digit[2].ToString();

        var number3 = GameObject.Find("3").GetComponent<Text>();
        number3.text = digit[3].ToString();
    }

    public void Button0(){
        Debug.Log("0");
    }
    public void Button1(){
        Debug.Log("1");
    }
    public void Button2(){
        Debug.Log("2");
    }
    public void Button3(){
        Debug.Log("3");
    }
    public void Button4(){
        Debug.Log("4");
    }
    public void Button5(){
        Debug.Log("5");
    }
    public void Button6(){
        Debug.Log("6");
    }
    public void Button7(){
        Debug.Log("7");
    }
    public void Button8(){
        Debug.Log("8");
    }
    public void Button9(){
        Debug.Log("9");
    }
    public void ButtonEnter(){
        Debug.Log("Enter");
    }

    public void ButtonErase(){
        Debug.Log("Erase");
    }
}
