using UnityEngine;
using static SetDifficulty;

public class GameDifficultyManager : MonoBehaviour
{
    public static GameDifficultyManager Instance;
    public GameDifficulty CurrentDifficulty;

    private void Awake()
    {
        Instance = this;
    }
    void Start()
    {
        CurrentDifficulty = ChooseGameTypeAndDifficultyUI.Instance.GetGameDifficulty();
    }

    void Update()
    {
        switch (CurrentDifficulty)
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
