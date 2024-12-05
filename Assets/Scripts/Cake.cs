using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cake : MonoBehaviour
{
    public GameObject endScreen;

    //when cake is collected, message appears
    public void OnTriggerEnter2D(Collider2D other){
        Destroy(gameObject); //cake destroyed
        endScreen.SetActive(true); //screen shown
    }
}
