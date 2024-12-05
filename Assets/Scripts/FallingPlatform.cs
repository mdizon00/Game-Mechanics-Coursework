using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingPlatform : MonoBehaviour
{

    private float fallDelay = 0.2f;
    private float destroyDelay = 2f;

    [SerializeField] private Rigidbody2D rb;

    //detects if player stands on top, starts timer
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.contacts[0].point.y > transform.position.y && collision.collider.tag == "Foot")
        {
            StartCoroutine(Fall());
        }
    }

    //small delay before platform starts to fall
    private IEnumerator Fall()
    {
        yield return new WaitForSeconds(fallDelay);
        rb.bodyType = RigidbodyType2D.Dynamic;
        Destroy(gameObject, destroyDelay); //platform destroyed after delay
    }

}
