using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private float bulletSpeed;
    [SerializeField] private float bulletDestroyTime;
    private Vector3 shootDir;
    public void Setup(Vector3 shootDir)
    {
        this.shootDir = shootDir;
        transform.rotation = Quaternion.LookRotation(shootDir, Vector3.up);
        Destroy(gameObject, bulletDestroyTime);
    }

    private void Update()
    {
        float speed = Mathf.Abs(bulletSpeed);
        transform.position += speed * Time.deltaTime * shootDir;
    }

}
