using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectCollision : MonoBehaviour
{

    [SerializeField] ParticleSystem particle;

    //if player jumps on top of box, box is destroyed
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.contacts[0].point.y > transform.position.y && collision.collider.tag == "Foot")
        {
            Destroy(gameObject); //box destroyed
            particle = Instantiate(particle, transform.position, transform.rotation); //instance of particle is made
            particle.Play(); //particle is played
        }

    }


}
