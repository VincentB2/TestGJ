﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RandomPaper : MonoBehaviour
{
    void Start()
    {
        var gen = GameObject.Find("Generator").GetComponent<Generator>();
        var number0 = GameObject.Find("paper (0)").GetComponent<Text>();
        var number1 = GameObject.Find("paper (1)").GetComponent<Text>();
        var number2 = GameObject.Find("paper (2)").GetComponent<Text>();
        var number3 = GameObject.Find("paper (3)").GetComponent<Text>();

        number0.text = gen.genCode0.ToString();
        number1.text = gen.genCode1.ToString();
        number2.text = gen.genCode2.ToString();
        number3.text = gen.genCode3.ToString();



        /*GeneratorCode0 = Random.Range(0, 10);
        GeneratorCode1 = Random.Range(0, 10);
        GeneratorCode2 = Random.Range(0, 10);
        GeneratorCode3 = Random.Range(0, 10);*/
        
        /*Debug.Log(GeneratorCode0);
        Debug.Log(GeneratorCode1);
        Debug.Log(GeneratorCode2);
        Debug.Log(GeneratorCode3);*/
    }

    void Update()
    {
    }
}