using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectCollision : MonoBehaviour
{

    [SerializeField] ParticleSystem particle;

    private void OnCollisionEnter2D(Collision2D collision)
    {

        if(collision.contacts[0].point.y > transform.position.y && collision.collider.tag == "Foot")
        {
            Destroy(gameObject);
            particle = Instantiate(particle, transform.position, transform.rotation);
            particle.Play();
        }

    }


}
