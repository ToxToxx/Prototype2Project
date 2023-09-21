using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GameOverManager : MonoBehaviour
{
    [SerializeField] private GameObject gameOverUI;
    [SerializeField] private GameObject gameWonUI;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!Player.Instance.IsDestroyed())
        {
            if (GameManager.Instance.GetScoreSwitcher() && !GameManager.Instance.GetTimeSwitcher())
            {
                GameOnScoreOver();
            }
            else if (GameManager.Instance.GetTimeSwitcher() && !GameManager.Instance.GetScoreSwitcher())
            {
                GameOnTimeOver();
            }
        } 
        else
        {
            GameOver();
        }
        
    }

    private void GameOnScoreOver()
    {
        
    }
    private void GameOnTimeOver()
    {
        
    }
    private void GameOver()
    {

    }
}
