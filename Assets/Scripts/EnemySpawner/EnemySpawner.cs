using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public static EnemySpawner Instance;

    [SerializeField] private GameObject enemyPr;
    [SerializeField] private float enemyRangeX;
    [SerializeField] private int enemyMax;
    [SerializeField] private int enemyCurrent;

    private void Awake()
    {
        Instance = this;
    }
    private void Start()
    {
        enemyCurrent = 0;
    }
    private void Update()
    {   
        if(enemyCurrent < enemyMax)
        {
            SpawnEnemy(enemyPr);
            enemyCurrent++;  
        }
    }

    public void DecreaseCurrentEnemy()
    {
        enemyCurrent--;
    }

    private void SpawnEnemy(GameObject enemy)
    {
        Instantiate(enemy, transform.position, Quaternion.identity);
    }
}
