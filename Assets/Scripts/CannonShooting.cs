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
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {

        distance = Vector2.Distance(transform.position, player.transform.position);

        if(distance < 50){

            timer += Time.deltaTime;

            if (timer > 0.8) {
                timer = 0;
                shoot();
            }
        }
    }

    void shoot() {
        Instantiate(bullet, bulletPos.position, Quaternion.identity);
    }
}
