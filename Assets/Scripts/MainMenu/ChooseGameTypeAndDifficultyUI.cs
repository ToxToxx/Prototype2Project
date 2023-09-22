using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ChooseGameTypeAndDifficultyUI : MonoBehaviour
{
    [SerializeField] private GameObject mainMenuUI;
    [SerializeField] private TextMeshProUGUI difficultyText;
    [SerializeField] private TextMeshProUGUI gameTypeText;
    [SerializeField] private Button difficultyHideButton;
    [SerializeField] private Button setGameTypeButton;
    [SerializeField] private Button setDifficultyButton;

    private void Awake()
    {

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
            HideChooseScreen();
            mainMenuUI.GetComponent<MainMenuUI>().ShowMainMenu();
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

}
