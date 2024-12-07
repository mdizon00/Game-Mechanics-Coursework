using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coinCollection : MonoBehaviour
{

    //if object touches coin
    void OnTriggerEnter2D(Collider2D other) {

        if (other.CompareTag("Player")){
            scoreUpdate.instance.addPointCoin(); //updates score
            Destroy(gameObject); //destroys coin
        }
    }

}
