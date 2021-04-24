using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int health = 3;

    private void OnCollisionEnter(Collision coll)
    {
        Enemy enemy = coll.collider.gameObject.GetComponent<Enemy>();

        if (enemy != null)
        {
            CollidedWithEnemy(enemy);
        }
    }

    private void CollidedWithEnemy(Enemy enemy)
    {
        enemy.Attack(this);

        if (health <= 0)
        {
            
        }
        {
            
        }
    }
}
