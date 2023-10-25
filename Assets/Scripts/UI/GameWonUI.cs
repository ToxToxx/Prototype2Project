using TMPro;
using UnityEngine;


public class GameWonUI : MonoBehaviour, IUserInterfaceWindow
{
    [SerializeField] private TextMeshProUGUI _gameWonScoreText;
    [SerializeField] private TextMeshProUGUI _gameWonTimeText;
    [SerializeField] private TextMeshProUGUI _gameWonBestScoreText;
   
    void Update()
    {
        ShowResultsCommand.ShowResults(_gameWonScoreText, _gameWonTimeText, _gameWonBestScoreText);
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
