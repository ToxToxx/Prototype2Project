using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField] private float enemySpeed;
    private Vector3 movedir;

    private void Start()
    {
        movedir = DefensePoint.Instance.gameObject.transform.position - transform.position;
    }
    void Update()
    {
        EnemyMove();
    }

    private void EnemyMove()
    {
        transform.Translate(enemySpeed * Time.deltaTime * movedir);
    }

}
