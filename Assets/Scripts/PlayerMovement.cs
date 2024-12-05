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
        horizontal = Input.GetAxisRaw("Horizontal");

        if (Input.GetButtonDown("Jump") && IsGrounded())
        {
            body.velocity = new Vector2(body.velocity.x, jumpingPower);
        }

        if (Input.GetButtonUp("Jump") && body.velocity.y > 0f)
        {
            body.velocity = new Vector2(body.velocity.x, body.velocity.y * 0.5f);
        }

        Flip();

    }

    private void FixedUpdate()
    {

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

    private bool IsGrounded()
    {
        return Physics2D.OverlapCircle(groundCheck.position, 0.2f, groundLayer);
    }

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
