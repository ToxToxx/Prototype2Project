using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public static EnemySpawner Instance;

    [SerializeField] private GameObject enemyPr;
    [SerializeField] private int enemyRangeX;
    [SerializeField] private int enemyMax;
    [SerializeField] private int enemyCurrent;
    [SerializeField] private float maxTimer;
    private float currentTimer;
    private float randomPositionX;

    private void Awake()
    {
        Instance = this;
    }
    private void Start()
    {
        enemyCurrent = 0;
        currentTimer = 0;
    }
    private void Update()
    {
        randomPositionX = Random.Range(-enemyRangeX, enemyRangeX);
        currentTimer += Time.deltaTime;

        if(enemyCurrent < enemyMax && currentTimer > maxTimer)
        {
            SpawnEnemy(enemyPr, randomPositionX);

            enemyCurrent++;
            currentTimer = 0;
        }
    }

    public void DecreaseCurrentEnemy()
    {
        enemyCurrent--;
    }

    private void SpawnEnemy(GameObject enemy, float randomPositionX)
    {

        Instantiate(enemy, new Vector3(randomPositionX, transform.position.y, transform.position.z), Quaternion.identity);
    }
    
    public void DecreaseMaxTimer(float timeAmount)
    {
        maxTimer -= timeAmount;
    }

    public float GetMaxTimer()
    {
        return maxTimer;
    }
}
