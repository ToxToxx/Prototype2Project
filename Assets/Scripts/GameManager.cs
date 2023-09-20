using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private bool timeSwitcher;
    [SerializeField] private bool scoreSwitcher;
    void Start()
    {
        timeSwitcher = false;
        scoreSwitcher = true;
    }

    // Update is called once per frame
    void Update()
    {
        ScoreUI.Instance.SetScoreType(scoreSwitcher);
        TimeUI.Instance.SetTimeSwitch(timeSwitcher);
    }
}
