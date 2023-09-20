using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TimeUI : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI timeText;
    [SerializeField] private bool timeSwitch;
    [SerializeField] private float maxTime;

    private float currentTime;
    private void Start()
    {
        currentTime = 0;
    }
    void Update()
    {
        currentTime += Time.deltaTime;
        string formattedTime = currentTime.ToString("0.00");
        if (timeSwitch)
        {
            timeText.color = Color.red;
            timeText.text = "Time: " + formattedTime + " / " + maxTime;
        }
        else
        {
            timeText.color = Color.yellow;
            timeText.text = "Time: " + formattedTime;
        }
       
    }
}
