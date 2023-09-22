using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static SetGameType;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    private GameType gameType;
    private bool timeSwitcher;
    private bool scoreSwitcher;

    private void Awake()
    {
        Instance = this;
    }
    void Start()
    {
        gameType = ChooseGameTypeAndDifficultyUI.Instance.GetGameType();
    }

    void Update()
    {
        switch (gameType)
        {
            case GameType.Score:
                SetScoreType();
                break;
            case GameType.Time:
                SetTimeType();
                break;
            case GameType.Survival:
                SetSurvivalType();
                break;
        }
    }

    public void SetTimeSwitcher(bool timeSwitch)
    {
        timeSwitcher = timeSwitch;
    }
    public void SetScoreSwitcher(bool scoreSwitch)
    {
        scoreSwitcher = scoreSwitch;
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
