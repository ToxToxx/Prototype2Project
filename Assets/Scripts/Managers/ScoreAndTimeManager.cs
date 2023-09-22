using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreAndTimeManager : MonoBehaviour
{
    [SerializeField] private int score;
    [SerializeField] private int maxScore;
    [SerializeField] private float maxTime;
    private float currentTime;

    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        currentTime = 0;
    }

    // Update is called once per frame
    void Update()
    {
        currentTime += Time.deltaTime;
    }


    public void SetScore(int scoreAmount)
    {
        score += scoreAmount;
    }



    public int GetScore()
    {
        return score;
    }

    public int GetMaxScore()
    {
        return maxScore;
    }
}
