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
        if (Player.Instance.IsDestroyed())
        {

        }
        if (GameManager.Instance.GetScoreSwitcher())
        {
            GameOnScoreOver();
        }
    }

    private void GameOnScoreOver()
    {
        
    }
}
