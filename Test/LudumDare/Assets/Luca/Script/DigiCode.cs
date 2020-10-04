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

    public GameObject lightAfterVictory;

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

    public void addNumber(int number){
        var number0 = GameObject.Find("0").GetComponent<Text>();
        var number1 = GameObject.Find("1").GetComponent<Text>();
        var number2 = GameObject.Find("2").GetComponent<Text>();
        var number3 = GameObject.Find("3").GetComponent<Text>();

        if(whichOne == 0){
            digit[0] = number;
            number0.text = digit[0].ToString();
        }else if(whichOne == 1){
            digit[1] = number;
            number1.text = digit[1].ToString();
        }else if(whichOne == 2){
            digit[2] = number;
            number2.text = digit[2].ToString();
        }else if(whichOne == 3){
            digit[3] = number;
            number3.text = digit[3].ToString();
        }
        FindObjectOfType<AudioManager>().Play("BipGenerateur");
        whichOne++;
    } 

    public void Button0(){
        addNumber(0);
    }
    public void Button1(){
        addNumber(1);
    }
    public void Button2(){
        addNumber(2);
    }
    public void Button3(){
        addNumber(3);
    }
    public void Button4(){
        addNumber(4);
    }
    public void Button5(){
        addNumber(5);
    }
    public void Button6(){
        addNumber(6);
    }
    public void Button7(){
        addNumber(7);
    }
    public void Button8(){
        addNumber(8);
    }
    public void Button9(){
        addNumber(9);
    }
    public void ButtonEnter(){
        var gen = GameObject.Find("Generator").GetComponent<Generator>();
        if(digit[0] == gen.genCode0){
            if(digit[1] == gen.genCode1){
                if(digit[2] == gen.genCode2){
                    if(digit[3] == gen.genCode3){
                        Debug.Log("Bien joué");
                        gen.closeDigit();
                        gen.GeneratorIsOn = true;
                        lightAfterVictory.SetActive(true);
                    }else{
                        ButtonErase();
                    }
                }else{
                    ButtonErase();
                }
            }else{
                ButtonErase();
            }
            FindObjectOfType<AudioManager>().Play("BipGenerateur");
        }else{
            ButtonErase();
        }
        
    }

    public void ButtonErase(){
        var gen = GameObject.Find("Generator").GetComponent<Generator>();
        
        if(digit[0] == 0){
            if(digit[1] == 0){
                if(digit[2] == 0){
                    if(digit[3] == 0){
                        gen.closeDigit();
                    }
                }
            }
        }

        whichOne = 0;
        digit[0] = 0;
        digit[1] = 0;
        digit[2] = 0;
        digit[3] = 0;
        FindObjectOfType<AudioManager>().Play("BipGenerateur");
        
    }
}
