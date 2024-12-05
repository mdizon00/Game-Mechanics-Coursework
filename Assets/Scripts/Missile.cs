using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Missile : MonoBehaviour
{
    private Rigidbody2D rb;
    private GameObject player;
    public float force;
    private float timer;

    public float damage;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); //sets rigidbody from inspector
        player = GameObject.FindGameObjectWithTag("Player"); //sets player as object with player tag

        //direction and speed of bullet set
        Vector3 direction = player.transform.position - transform.position; //goes towards player current position
        rb.velocity = new Vector2(direction.x, direction.y).normalized*force;

        //missile rotates according to direction its travelling
        float rotation = Mathf.Atan2(-direction.y, -direction.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0,0,rotation);
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime; //timer count up

        if(timer > 10){ //missile is destoyed after 10 counts
            Destroy(gameObject);
        }
    }


    //player damage
    void OnTriggerEnter2D(Collider2D other){
        if(other.CompareTag("Player")) {

            PlayerHealth playerHealth = other.GetComponent<PlayerHealth>(); //finds player health scripts
            if(playerHealth != null){
                playerHealth.Damage(damage);//damage is set in inspector
            }
            Destroy(gameObject); //destroys missile
        }
    }
}
