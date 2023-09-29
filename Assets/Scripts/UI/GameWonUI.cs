using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameWonUI : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI gameWonScoreText;
    [SerializeField] private TextMeshProUGUI gameWonTimeText;
    [SerializeField] private TextMeshProUGUI gameWonBestScoreText;
   
    void Update()
    {
        ShowResultsCommand.ShowResults(gameWonScoreText, gameWonTimeText, gameWonBestScoreText);
    }

    public void GameWonShow()
    {
        gameObject.SetActive(true);
    }
    public void GameWonHide()
    {
        gameObject.SetActive(false);
    }
}
