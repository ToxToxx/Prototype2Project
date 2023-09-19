using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefensePoint : MonoBehaviour
{
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<EnemyDamage>())
        {
            PlayerHealth.Instance.TakeDamage(other.GetComponent<EnemyDamage>().GetDamage());
        }
    }

}
