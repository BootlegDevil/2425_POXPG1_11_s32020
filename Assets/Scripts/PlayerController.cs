using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5;
    public float runSpeed = 10;
    public float jumpForce = 300;
    public Rigidbody2D rb;
    public Animator anim;
    public SpriteRenderer spriteRenderer;

    public GroundChecker GroundChecker;
    public Player_Health healthPlayer;
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        healthPlayer = GetComponent<Player_Health>();
        anim = GetComponent<Animator>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        if(healthPlayer.isDead) return;

        float moveInput = Input.GetAxis("Horizontal");
        if (moveInput >= 0)
        {
            spriteRenderer.flipX = false;
        }
        else if (moveInput < 0)
        {
            spriteRenderer.flipX = true;
        }

        if (moveInput != 0)
        {
            anim.SetBool("IsRun", true);
        }
        else
        {
            anim.SetBool("IsRun", false);
        }

        //Sprint
        if(Input.GetKey(KeyCode.LeftShift))
        {
            rb.velocity = new Vector2(moveInput * runSpeed, rb.velocity.y);
        }
        else
        {
            rb.velocity = new Vector2(moveInput * moveSpeed,rb.velocity.y);
        }


        if (Input.GetKeyDown(KeyCode.Space) && GroundChecker.isGrounded)
        {
            rb.AddForce(Vector2.up * jumpForce);
            anim.SetBool("IsJumping", true);
        }
    }
}
