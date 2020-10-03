﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class TimeManager : MonoBehaviour
{
    public TMP_Text secondsTXT;
    public TMP_Text minutesTXT;
    public TMP_Text hoursTXT;
    public IntVariable seconds;
    public IntVariable minutes;
    public IntVariable hours;
    public IntVariable totalSeconds;
    private float timeSave;

    public int durationLevel;


    float scaleTime;


    private void Start()
    {
        totalSeconds.Value = 0;
        seconds.Value = 0;
        minutes.Value = 42;
        hours.Value = 3;
        timeSave = Time.time;

        scaleTime = (float)60 / durationLevel;
    }

    private void Update()
    {
        Debug.Log(scaleTime);
        if(Time.time >= timeSave + scaleTime && !(seconds.Value == 59))
        {

            timeSave += scaleTime;
                seconds.Value++;
                totalSeconds.Value++;

        }

        else if (Time.time >= timeSave + scaleTime && seconds.Value == 59 && !(minutes.Value == 59))
        {
            timeSave += scaleTime;
            seconds.Value = 0;
            minutes.Value++;
            totalSeconds.Value++;
        }
        else if (Time.time >= timeSave + scaleTime && seconds.Value == 59 && (minutes.Value == 59) && !(hours.Value == 24))
        {
            timeSave += scaleTime;
            seconds.Value = 0;
            minutes.Value = 0;
            hours.Value++;
            totalSeconds.Value++;
        }
        else if (Time.time >= timeSave + scaleTime && seconds.Value == 59 && (minutes.Value == 59) && hours.Value == 24)
        {
            timeSave += scaleTime;
            seconds.Value = 0;
            minutes.Value = 0;
            hours.Value = 0;
            totalSeconds.Value++;
        }

        setTime();

        if(totalSeconds.Value >= durationLevel)
        {
            
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex, LoadSceneMode.Single);
        }
    }

    private void setTime()
    {
        setSeconds();
        SetMinutes();
        SetHours();
    }

    private void setSeconds()
    {
        if (seconds.Value <10)
        {
            secondsTXT.text = "0" + seconds.Value.ToString();
        } else
        {
            secondsTXT.text = seconds.Value.ToString();
        }

    }

    private void SetMinutes()
    {
        if (minutes.Value < 10)
        {
            minutesTXT.text = "0" + minutes.Value.ToString();
        }
        else
        {
            minutesTXT.text = minutes.Value.ToString();
        }
    }

    private void SetHours()
    {
        if (hours.Value < 10)
        {
            hoursTXT.text = "0" + hours.Value.ToString();
        }
        else
        {
            hoursTXT.text = hours.Value.ToString();
        }
    }




}