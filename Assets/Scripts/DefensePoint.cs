using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefensePoint : MonoBehaviour
{
    public event EventHandler OnPlayerGetDamage;
    public static DefensePoint Instance;
    private void Awake()
    {
        Instance = this;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<EnemyDamage>())
        {
            PlayerHealth.Instance.TakeDamage(other.GetComponent<EnemyDamage>().GetDamage());
            Destroy(other.gameObject, 3);
            OnPlayerGetDamage?.Invoke(this,EventArgs.Empty);
        }
    }

}
