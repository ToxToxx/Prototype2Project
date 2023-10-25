using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public static EnemySpawner Instance;

    [SerializeField] private List<GameObject> _enemyPrefabsList;

    [SerializeField] private int _enemyRangeX = 10;
    [SerializeField] private int _enemyMax = 5;
    [SerializeField] private int _enemyCurrent;
    [SerializeField] private float _maxTimer = 3;

    private float _currentTimer;
    private float _randomPositionX;

    private void Awake()
    {
        Instance = this;
    }
    private void Start()
    {
        _enemyCurrent = 0;
        _currentTimer = 0;
    }
    private void Update()
    {
        _randomPositionX = Random.Range(-_enemyRangeX, _enemyRangeX);
        _currentTimer += Time.deltaTime;

        if(_enemyCurrent < _enemyMax && _currentTimer > _maxTimer)
        {
            SpawnEnemy(_enemyPrefabsList, _randomPositionX);

            _enemyCurrent++;
            _currentTimer = 0;
        }
    }

    public void DecreaseCurrentEnemy()
    {
        _enemyCurrent--;
    }

    private void SpawnEnemy(List<GameObject> enemy, float randomPositionX)
    {
        int index = Random.Range(0, _enemyPrefabsList.Count);
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
