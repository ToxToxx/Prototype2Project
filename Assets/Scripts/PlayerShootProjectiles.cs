using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShootProjectile : MonoBehaviour
{
    [SerializeField] private Transform gunEndPosition;
    [SerializeField] private Transform gunStartPosition;
    [SerializeField] private Transform pfBullet;
    private void Start()
    {
        GameInput.Instance.OnShoot += GameInput_OnShoot;
    }

    private void GameInput_OnShoot(object sender, System.EventArgs e)
    {
        Transform bulletTransform = Instantiate(pfBullet, transform.position, Quaternion.identity);

        Vector3 shootDir = (gunEndPosition.position - gunStartPosition.position).normalized; 
        bulletTransform.GetComponent<Bullet>().Setup(shootDir);
    }
}
