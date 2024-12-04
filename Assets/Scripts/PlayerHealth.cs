using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int maxHealth = 10;
    public int health;
    public EnemyMovement enemyMovement;

    // Start is called before the first frame update
    void Start()
    {
        health = maxHealth;
    }

    public void Damage(int damage)
    {
        health -= damage;

        if(health <= 0)
        {
            enemyMovement.isChasing = false;
            Destroy(gameObject);
        }
    }

}
