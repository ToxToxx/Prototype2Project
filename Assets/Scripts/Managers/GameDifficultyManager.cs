using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static SetDifficulty;

public class GameDifficultyManager : MonoBehaviour
{
    public static GameDifficultyManager Instance;
    public GameDifficulty currentDifficulty;

    private void Awake()
    {
        Instance = this;
    }
    void Start()
    {
        currentDifficulty = ChooseGameTypeAndDifficultyUI.Instance.GetGameDifficulty();
    }

    void Update()
    {
        switch (currentDifficulty)
        {
            case GameDifficulty.Easy:
                SetEasyDifficulty();
                break; 
            case GameDifficulty.Medium:
                SetMediumDifficulty();
                break; 
            case GameDifficulty.Hard:
                SetHardDifficulty();
                break;
        }

    }
}
