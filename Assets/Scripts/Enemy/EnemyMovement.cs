using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField] private float _enemySpeed = 3;
    private Transform enemyTransform;

    private void Start()
    {
       enemyTransform = transform;
    }

    void Update()
    {
        enemyTransform.Translate(_enemySpeed * Time.deltaTime * Vector3.back);
    }


}
