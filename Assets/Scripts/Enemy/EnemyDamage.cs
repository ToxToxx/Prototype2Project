using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamage : MonoBehaviour
{
    [SerializeField] private int damageAmount;

    public int GetDamage()
    {
        return damageAmount;
    }
}
