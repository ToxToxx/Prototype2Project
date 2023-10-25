using TMPro;
using UnityEngine;

public class GameOverUI : MonoBehaviour, IUserInterfaceWindow
{
    [SerializeField] private TextMeshProUGUI _gameOverScoreText;
    [SerializeField] private TextMeshProUGUI _gameOverTimeText;
    [SerializeField] private TextMeshProUGUI _gameOverBestScoreText;

    void Update()
    {
        ShowResultsCommand.ShowResults(_gameOverScoreText, _gameOverTimeText, _gameOverBestScoreText);
    }

    public void Show()
    {
        gameObject.SetActive(true);
    }
    public void Hide()
    {
        gameObject.SetActive(false);
    }
}
