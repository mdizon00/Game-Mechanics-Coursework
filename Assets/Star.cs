using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Star : MonoBehaviour
{
    public GameObject arrow;

    void start(){
        arrow.SetActive(false);
    }

    void OnTriggerEnter2D(Collider2D other) {

        if(other.CompareTag("Player")){
            Destroy(gameObject);

            PlayerMovement movement = other.GetComponent<PlayerMovement>();
            movement.jumpingPower = 20f;

            arrow.SetActive(true);
        }
    }


}
