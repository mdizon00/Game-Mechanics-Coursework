using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Level3Open : MonoBehaviour
{

    //opends level 3 on button click
    public void OnTriggerEnter2D(Collider2D other){
        if(other.CompareTag("Player")){
            SceneManager.LoadScene("3_Could Requirements");
        }
    }

}
