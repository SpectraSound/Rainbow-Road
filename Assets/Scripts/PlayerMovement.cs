using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public Rigidbody2D rb2D;
    public float JumpSpeed;
    public float MoveSpeed;
    public bool IsGrounded = true;
    public BoxCollider2D PlayerCollider2D;
    public BoxCollider2D GroundCollider2D;
    private Collision2D collision2D;
    
    

    // Use this for initialization
    void Start() {
        rb2D = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
	void FixedUpdate () {
	    PlayerJump();
        PlayerMove();
	}

    public void PlayerJump() {

        if (Input.GetKey(KeyCode.W) && IsGrounded)
        {
            rb2D.AddForce(new Vector2(0, JumpSpeed), ForceMode2D.Impulse);
            IsGrounded = !IsGrounded;
        }

        if (PlayerCollider2D.IsTouching(GroundCollider2D)) {
            IsGrounded = true;
        }
    }

    public void PlayerMove() {
        if (Input.GetKey(KeyCode.D)) {
            rb2D.AddForce(new Vector2(MoveSpeed,0));
        }

        if (Input.GetKey(KeyCode.A)) {
            rb2D.AddForce(new Vector2(-MoveSpeed, 0));
        }
    }

    private void OnTriggerEnter2D(Collider2D Ground) {
        
    }

}
