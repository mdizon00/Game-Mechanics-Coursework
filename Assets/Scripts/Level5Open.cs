using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Level5Open : MonoBehaviour
{
    //opens level 5 on button click
    public void OnTriggerEnter2D(Collider2D other){
        if(other.CompareTag("Player")){
            SceneManager.LoadScene("5_End Scene");
        }
    }
}
