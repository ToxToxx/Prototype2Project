using TMPro;
using UnityEngine;


public class GameWonUI : MonoBehaviour, IUserInterfaceWindow
{
    [SerializeField] private TextMeshProUGUI gameWonScoreText;
    [SerializeField] private TextMeshProUGUI gameWonTimeText;
    [SerializeField] private TextMeshProUGUI gameWonBestScoreText;
   
    void Update()
    {
        ShowResultsCommand.ShowResults(gameWonScoreText, gameWonTimeText, gameWonBestScoreText);
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
