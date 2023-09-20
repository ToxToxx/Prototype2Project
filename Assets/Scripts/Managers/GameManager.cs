using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    [SerializeField] private bool timeSwitcher;
    [SerializeField] private bool scoreSwitcher;

    private void Awake()
    {
        Instance = this;
    }
    void Start()
    {
        timeSwitcher = false;
        scoreSwitcher = true;
    }

    void Update()
    {
        ScoreUI.Instance.SetScoreType(scoreSwitcher);
        TimeUI.Instance.SetTimeSwitch(timeSwitcher);
    }

    public bool GetTimeSwitcher()
    {
        return timeSwitcher;
    }
    public bool GetScoreSwitcher()
    {
        return scoreSwitcher;
    }
}
