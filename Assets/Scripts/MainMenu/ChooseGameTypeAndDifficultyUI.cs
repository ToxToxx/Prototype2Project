using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using static SetDifficulty;

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
            HideChooseScreen();
            mainMenuUI.GetComponent<MainMenuUI>().ShowMainMenu();
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
        switch (gameDifficulty)
        {
            case GameDifficulty.Easy:
                gameDifficulty = GameDifficulty.Medium;
                break;
            case GameDifficulty.Medium:
                gameDifficulty = GameDifficulty.Hard;
                break;
            case GameDifficulty.Hard:
                gameDifficulty = GameDifficulty.Easy;
                break;
            default:
                break;
        }
        difficultyText.text = "DIFFICULTY: " + gameDifficulty;
    }

    public GameDifficulty GetGameDifficulty()
    {
        return gameDifficulty;
    }

}
