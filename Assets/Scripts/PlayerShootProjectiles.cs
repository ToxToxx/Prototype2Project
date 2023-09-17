using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShootProjectile : MonoBehaviour
{
    [SerializeField] private Transform pfBullet;
    private void Start()
    {
        GameInput.Instance.OnShoot += GameInput_OnShoot;
    }

    private void GameInput_OnShoot(object sender, System.EventArgs e)
    {
        Instantiate(pfBullet, Player.Instance.transform.position, Quaternion.identity);
    }
}
