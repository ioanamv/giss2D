using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1 : MonoBehaviour
{
    public float speed;
    public float jumpForce;

	public Transform groundCheck;
	public float groundCheckRadious;
	public LayerMask groundMask;

    private bool isGrounded;
    private Rigidbody2D rb;

    private void Start()
    {
        rb= GetComponent<Rigidbody2D>();
    }

    void FixedUpdate() // potrivit cand lucram cu rigidbody
    {
        float moveInput = 0;
        if (Input.GetKey(KeyCode.LeftArrow)) //getkey - pt apasare continua, getkeydown - doar o data
        {
            moveInput = -1;
        }
		if (Input.GetKey(KeyCode.RightArrow))
		{
			moveInput = 1;
		}

		rb.velocity=new Vector2(moveInput*speed, rb.velocity.y);
		isGrounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadious, groundMask);
	}

	private void Update()
	{
        if (isGrounded && Input.GetKeyDown(KeyCode.UpArrow))
		{
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
		}
	}
}
