using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamage : MonoBehaviour
{
    public float damage;
    public PlayerHealth playerHealth;
    public PlayerMovement playerMovement;

    //when collision happens
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //if collision is with player, knockback effect happens
        if(collision.gameObject.tag == "Player")
        {
            playerMovement.hitCounter = playerMovement.hitTotalTime;
            if(collision.transform.position.x <= transform.position.x) {
                playerMovement.hitFromRight = true; //player knocks to the right
            }
            if(collision.transform.position.x > transform.position.x) {
                playerMovement.hitFromRight = false; //player knocks to left
            }

            playerHealth.Damage(damage); //player health descreased
        }
    }
}
