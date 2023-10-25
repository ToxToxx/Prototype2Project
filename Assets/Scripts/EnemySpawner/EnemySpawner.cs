using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public static EnemySpawner Instance;

    [SerializeField] private List<GameObject> enemyPrefabs;
    [SerializeField] private int _enemyRangeX = 10;
    [SerializeField] private int _enemyMax = 5;
    [SerializeField] private int enemyCurrent;
    [SerializeField] private float _maxTimer = 3;
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
        randomPositionX = Random.Range(-_enemyRangeX, _enemyRangeX);
        currentTimer += Time.deltaTime;

        if(enemyCurrent < _enemyMax && currentTimer > _maxTimer)
        {
            SpawnEnemy(enemyPrefabs, randomPositionX);

            enemyCurrent++;
            currentTimer = 0;
        }
    }

    public void DecreaseCurrentEnemy()
    {
        enemyCurrent--;
    }

    private void SpawnEnemy(List<GameObject> enemy, float randomPositionX)
    {
        int index = Random.Range(0, enemyPrefabs.Count);
        Instantiate(enemy[index], new Vector3(randomPositionX, transform.position.y, transform.position.z), Quaternion.identity);
    }
    
    public void DecreaseMaxTimer(float timeAmount)
    {
        _maxTimer -= timeAmount;
    }

    public float GetMaxTimer()
    {
        return _maxTimer;
    }
}
