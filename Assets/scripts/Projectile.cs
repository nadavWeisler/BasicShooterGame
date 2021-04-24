using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Object = UnityEngine.Object;

public class Projectile : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private int damage;

    private Vector3 shootDirection;

    private void FixedUpdate()
    {
        transform.Translate(shootDirection * speed, Space.World);
        Object.Destroy(gameObject, 2f);
    }

    public void FireProjectile(Ray shootRay)
    {
        shootDirection = shootRay.direction;
        transform.LookAt(shootDirection);
        transform.position = shootRay.origin;
    }
    
    private void OnCollisionEnter(Collision other)
    {
        Enemy enemy = other.collider.gameObject.GetComponent<Enemy>();
        if (enemy)
        {
            Destroy(gameObject);
            enemy.TakeDamage(damage);
        }
    }
}
