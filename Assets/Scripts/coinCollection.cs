using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coinCollection : MonoBehaviour
{
    private int score;

    //if object touches coin
    void OnTriggerEnter2D(Collider2D other) {

        scoreUpdate.instance.addPointCoin(); //updates score
        Destroy(gameObject); //destroys coin
    }

}
