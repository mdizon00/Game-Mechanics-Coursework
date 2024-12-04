using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public Transform[] patrolPoints;
    public float moveSpeed;
    public int patrolDestination;
    public SpriteRenderer zombieSprite;

    public Transform playerTransform;
    public bool isChasing;
    public float chaseDistance;

    void Update()
    {
        if (isChasing && playerTransform != null) {

            if(transform.position.x > playerTransform.position.x) {
                zombieSprite.flipX = true;
                transform.position += Vector3.left * moveSpeed * Time.deltaTime;
            }
            if(transform.position.x < playerTransform.position.x) {
                zombieSprite.flipX = false;
                transform.position += Vector3.right * moveSpeed * Time.deltaTime;
            }

        } else if (isChasing == false && playerTransform != null){

            if (Vector2.Distance(transform.position, playerTransform.position) < chaseDistance) {
                isChasing = true;
            }

            Patroling();
        } else {
            Patroling();
        }

    }

    public void Patroling() {
        if(patrolDestination == 0)
        {
            zombieSprite.flipX = true;
            transform.position = Vector2.MoveTowards(transform.position, patrolPoints[0].position, moveSpeed * Time.deltaTime);

            if(Vector2.Distance(transform.position, patrolPoints[0].position) < .2f)
            {
                zombieSprite.flipX = false;
                patrolDestination = 1;
            }
        }

        if(patrolDestination == 1)
        {
            zombieSprite.flipX = false;
            transform.position = Vector2.MoveTowards(transform.position, patrolPoints[1].position, moveSpeed * Time.deltaTime);

            if(Vector2.Distance(transform.position, patrolPoints[1].position) < .2f)
            {
                zombieSprite.flipX = true;
                patrolDestination = 0;
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision){

        if (collision.collider.tag == "Box") {
            isChasing = false;
            //zombieSprite.flipX = !zombieSprite.flipX;
            Patroling();
        }
    }

}
