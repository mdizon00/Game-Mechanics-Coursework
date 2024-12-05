using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Star : MonoBehaviour
{
    public GameObject arrow;

    // Start is called before the first frame update
    void Start(){
        arrow.SetActive(false); //arrow to guide player is hidden
    }

    //checks for collision
    void OnTriggerEnter2D(Collider2D other) {

        //if player touches star
        if(other.CompareTag("Player")){
            Destroy(gameObject); //star destroyed

            PlayerMovement movement = other.GetComponent<PlayerMovement>(); //refers to player movement script
            movement.jumpingPower = 20f; //sets jump boost so player can jump higher

            arrow.SetActive(true); //arrow to guide player is shown
        }
    }


}
