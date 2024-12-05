using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Level2Open : MonoBehaviour
{

    // Start is called before the first frame update
    void Start(){
        gameObject.SetActive(false); //trigger zone is hidden until player achieves required score
    }

    //opens level 2 on button click
    public void OnTriggerEnter2D(Collider2D other){
        if(other.CompareTag("Player")){
            SceneManager.LoadScene("2_Should Requirements");
        }
    }



}
