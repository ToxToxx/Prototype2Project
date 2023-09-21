using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameWonUI : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI gameWonScoreText;
    [SerializeField] private TextMeshProUGUI gameWonTimeText;

    void Update()
    {
        ShowResultsCommand.ShowResults(gameWonScoreText, gameWonTimeText);
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
