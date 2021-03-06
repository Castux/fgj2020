﻿using UnityEngine;
using UnityEngine.UI;
using System;

public class Timer : MonoBehaviour
{
    public float DreamtimeInSeconds = 60f * 3f;
    public Text label;

    private float remainingTime;

    void Start()
    {
        remainingTime = DreamtimeInSeconds;
    }

    void Update()
    {
        remainingTime -= Time.deltaTime;

        if (remainingTime < 10)
        {
            FindObjectOfType<AlarmClock>().SoundAlarm(remainingTime);
        }

        if (remainingTime < 0 || Input.GetKeyDown(KeyCode.H))
        {
            remainingTime = 0;
            FindObjectOfType<PlayerProgression>().SwitchToDayTime();
        }
        else
        {
            label.text = TimeSpan.FromSeconds(remainingTime).ToString("mm\\:ss");
        }
    }
}
