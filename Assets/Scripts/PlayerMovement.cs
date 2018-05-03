using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public Rigidbody2D rb2D;
    public float JumpSpeed;
    public bool IsGrounded = true;

	// Use this for initialization
	void Start () {
	    rb2D = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
	    PlayerJump();
	}

    public void PlayerJump() {

        if (IsGrounded) {

            if (Input.GetKey(KeyCode.W)) {
                rb2D.AddForce(new Vector2(0, JumpSpeed), ForceMode2D.Impulse);
                IsGrounded = !IsGrounded;
            }
            
        }
        
        
    }

    public void PlayerMove() {
        
    }
}
