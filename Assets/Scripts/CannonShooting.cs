using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonShooting : MonoBehaviour
{
    public GameObject bullet;
    public Transform bulletPos;
    private float timer;
    private GameObject player;
    private float distance;


    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player"); //checks for game object with player tag
    }

    // Update is called once per frame
    void Update()
    {
        //if player game object exists
        if (player){

            distance = Vector2.Distance(transform.position, player.transform.position); //calculates distance between cannon and player

            //if player is within set distance below
            if(distance < 50){

            timer += Time.deltaTime;

            //how often missiles are shot
            if (timer > 0.8) {
                timer = 0; //resets timer
                shoot(); //runs method
            }
        }
        }

    }

    //creates instance of missile at the set poisition of bullet position
    void shoot() {
        Instantiate(bullet, bulletPos.position, Quaternion.identity);
    }
}
