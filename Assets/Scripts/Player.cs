using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
    public Rigidbody2D rb;
    public int movespeed;
    public int jumpPower;
    public Transform groundCheck;
    public float groundCheckRadius;
    public LayerMask whatIsGround;
    public int treats;
    public bool moveRight;
    public bool moveLeft;

    private bool onGround;
    private Animator anim;
    private int facing;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody2D>();
        movespeed = 2;
        jumpPower = 6;
        facing = 1;
        anim = GetComponent<Animator>();

    }
	
	// Update is called once per frame
	void Update () {
        if (moveLeft || Input.GetKey(KeyCode.LeftArrow))
        {
            rb.velocity = new Vector2(-movespeed, rb.velocity.y);
            anim.SetBool("Walking", true);
            if(facing == 1)
            {
                transform.localScale = new Vector3(-1f, 1f, 1f);
            }
            facing = 0;
        }
        else if (moveRight || Input.GetKey(KeyCode.RightArrow))
        {
            rb.velocity = new Vector2(movespeed, rb.velocity.y);
            anim.SetBool("Walking", true);
            if(facing == 0)
            {
                transform.localScale = new Vector3(1f, 1f, 1f);
                facing = 1;
            }
        }
        else {
            anim.SetBool("Walking", false);
            }
        if(Input.GetKey(KeyCode.Space) && onGround)
        {
            // rb.velocity = new Vector2(rb.velocity.x, jumpPower);
            jump();
        }
        
	}

    private void FixedUpdate()
    {
        onGround = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, whatIsGround);
    }

    public void jump() {

        if (onGround) {
            rb.velocity = new Vector2(rb.velocity.x, jumpPower);
        }
    }
}
