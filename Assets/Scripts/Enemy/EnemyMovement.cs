using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField] private float enemySpeed;

    void Update()
    {
        transform.Translate(enemySpeed * Time.deltaTime * Vector3.back);
    }


}
