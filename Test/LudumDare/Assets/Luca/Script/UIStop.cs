﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIStop : MonoBehaviour
{
    public float speed;
    public GameObject me;
    void Start()
    {
        
    }

    void Update()
    {
        RectTransform rectTransform = GameObject.Find("Lock").GetComponent<RectTransform>();

        rectTransform.Rotate(new Vector3(0,0, speed));

    }

    public void StopLaMachine(){
        RectTransform rectTransform = GameObject.Find("Lock").GetComponent<RectTransform>();
        var TargetArea = GameObject.Find("Target").GetComponent<CheckLock>();
        speed = 0;
        if(TargetArea.isLock){
            Debug.Log("GG");
            StartCoroutine("Good");
        }else{
            Debug.Log("t nul");
            StartCoroutine("Restart");

        }
    }

    IEnumerator Good(){
        var player = GameObject.Find("Player").GetComponent<Player>();

        yield return new WaitForSecondsRealtime(0.5f);
        player.isPaused = false;
        speed = 4;
        me.SetActive(false);
    }
    
    IEnumerator Restart(){
        var player = GameObject.Find("Player").GetComponent<Player>();

        yield return new WaitForSecondsRealtime(0.5f);
        player.isPaused = false;
        speed = 4;
        //me.SetActive(false);
    }
}