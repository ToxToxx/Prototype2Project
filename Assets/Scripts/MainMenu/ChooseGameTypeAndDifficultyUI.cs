using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using static SetDifficulty;
using static SetGameType;

public class ChooseGameTypeAndDifficultyUI : MonoBehaviour
{
    public static ChooseGameTypeAndDifficultyUI Instance;

    [SerializeField] private GameObject mainMenuUI;
    [SerializeField] private TextMeshProUGUI difficultyText;
    [SerializeField] private TextMeshProUGUI gameTypeText;
    [SerializeField] private Button difficultyHideButton;
    [SerializeField] private Button setGameTypeButton;
    [SerializeField] private Button setDifficultyButton;
    [SerializeField] private Button playButton;

    private GameDifficulty gameDifficulty;
    private GameType gameType;
    private void Awake()
    {
        Instance = this;

        difficultyHideButton.onClick.AddListener(() =>
        {
            HideChooseScreen();
            mainMenuUI.GetComponent<MainMenuUI>().ShowMainMenu();
        });
        setGameTypeButton.onClick.AddListener(() =>
        {
            ChangeGameType();
        });
        setDifficultyButton.onClick.AddListener(() =>
        {
            ChangeDifficulty();
        });
        playButton.onClick.AddListener(() =>
        {           
            Loader.Load(Loader.Scene.GameScene);
        });
    }
    private void Start()
    {
        HideChooseScreen();
    }

    public void ShowChooseScreen()
    {
        gameObject.SetActive(true);
    }

    public void HideChooseScreen()
    {
        gameObject.SetActive(false);
    }

    public void ChangeDifficulty()
    {
        string localizationDifficultyName = " ";
        switch (gameDifficulty)
        {
            case GameDifficulty.Easy:
                gameDifficulty = GameDifficulty.Medium;
                localizationDifficultyName = "�������";
                break;
            case GameDifficulty.Medium:
                gameDifficulty = GameDifficulty.Hard;
                localizationDifficultyName = "�������";
                break;
            case GameDifficulty.Hard:
                gameDifficulty = GameDifficulty.Easy;
                localizationDifficultyName = "������";
                break;
            default:
                break;
        }
        difficultyText.text = "���������: " + localizationDifficultyName;
    }

    public void ChangeGameType()
    {
        string localizationTypeName = " ";
        switch (gameType)
        {
            case GameType.Score:
                gameType = GameType.Time;
                localizationTypeName = "�����";
                break;
            case GameType.Time:
                gameType = GameType.Survival;
                localizationTypeName = "����";
                break;
            case GameType.Survival:
                gameType = GameType.Score;
                localizationTypeName = "����";
                break;
            default:
                break;
        }
        gameTypeText.text = "�����: " + localizationTypeName;
    }

    public GameDifficulty GetGameDifficulty()
    {
        return gameDifficulty;
    }
    public GameType GetGameType()
    {
        return gameType;
    }

}
