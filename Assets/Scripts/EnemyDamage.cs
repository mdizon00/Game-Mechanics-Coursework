using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamage : MonoBehaviour
{
    public int damage;
    public PlayerHealth playerHealth;
    public PlayerMovement playerMovement;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            playerMovement.hitCounter = playerMovement.hitTotalTime;
            if(collision.transform.position.x <= transform.position.x) {
                playerMovement.hitFromRight = true;
            }
            if(collision.transform.position.x > transform.position.x) {
                playerMovement.hitFromRight = false;
            }
            playerHealth.Damage(damage);
        }
    }
}
