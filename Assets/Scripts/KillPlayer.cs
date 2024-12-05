using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillPlayer : MonoBehaviour
{

    //when player touches void bar, player dies, death screen is shown
    public void OnTriggerEnter2D(Collider2D collision){
        PlayerHealth playerHealth = collision.GetComponent<PlayerHealth>();

        if (playerHealth != null){
            playerHealth.endGame();
        }
    }

}
