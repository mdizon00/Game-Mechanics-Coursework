using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private float horizontal;
    private float speed = 8f;
    public float jumpingPower;
    private bool isFacingRight = true;

    [SerializeField] public Rigidbody2D body;
    [SerializeField] public Transform groundCheck;
    [SerializeField] public LayerMask groundLayer;

    public float hitForce;
    public float hitCounter;
    public float hitTotalTime;
    public bool hitFromRight;


    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal"); //returns either 1 or -1

        if (Input.GetButtonDown("Jump") && IsGrounded()) //checks for spacebar press and if player is touching platform
        {
            body.velocity = new Vector2(body.velocity.x, jumpingPower); //jump
        }

        Flip(); //flip method

    }

    private void FixedUpdate()
    {

        //creates knockback effect when hit by enemy
        if (hitCounter <=0 ){
            body.velocity = new Vector2(horizontal * speed, body.velocity.y);
        } else {

            if(hitFromRight == true) {
                body.velocity = new Vector2(-hitForce,hitForce);
            }
            if(hitFromRight == false) {
                body.velocity = new Vector2(hitForce, hitForce);
            }

            hitCounter -= Time.deltaTime;
        }

    }

    //checks if player is touching ground
    private bool IsGrounded()
    {
        return Physics2D.OverlapCircle(groundCheck.position, 0.2f, groundLayer);
    }

    //checks which way player is walking and flips player accordingly
    private void Flip()
    {
        if (isFacingRight && horizontal < 0f || !isFacingRight && horizontal > 0f)
        {
            isFacingRight = !isFacingRight;
            Vector3 localScale = transform.localScale;
            localScale.x *= -1f;
            transform.localScale = localScale;
        }


    }
}
