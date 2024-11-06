using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WoodenBox : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collison.contacts[0].point.y > transform.position.y)
        {
            Instantiate(WoodenBoxParticleSystem, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }
}
