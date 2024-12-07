using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class itemCollection : MonoBehaviour
{

    //when food is collected, add set points and destroy food
    void OnTriggerEnter2D(Collider2D other) {

        if (other.CompareTag("Player")){
            scoreUpdate.instance.addPointItem();//add set points
            Destroy(gameObject); //destroy item
        }
    }

}
