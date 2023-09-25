using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TimeUI : MonoBehaviour
{
    public static TimeUI Instance;
    [SerializeField] private TextMeshProUGUI timeText;

    private void Awake()
    {
        Instance = this;
    }

    void Update()
    {
        string formattedTime = ScoreAndTimeManager.Instance.GetCurrentTime().ToString("0.00");
        if (GameManager.Instance.GetTimeSwitcher())
        {
            timeText.color = Color.red;
            timeText.text = "время: " + formattedTime + " / " + ScoreAndTimeManager.Instance.GetMaxTime();
        }
        else
        {
            timeText.color = Color.yellow;
            timeText.text = "время: " + formattedTime;
        }

    }
}

