using UnityEngine;

namespace Assets.Scripts {
    public class PlayerMovement : MonoBehaviour {

<<<<<<< HEAD
        public int JumpSpeed = 5;

        private Rigidbody2D Rb2D;
        private bool canJump;
        public static int _jumpCount;
=======
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
>>>>>>> 3241bce9ca864982bd9e6441b0c6855965ec2937

        void Start() {
            Rb2D = GetComponent<Rigidbody2D>();
        }

<<<<<<< HEAD
        void FixedUpdate() {
            PlayerJump();
        }

        void Update() {
            if (Input.GetKeyDown(KeyCode.W)) {
                canJump = true;
                _jumpCount++;
            }
        }

        void PlayerJump() {
            if (canJump) {
                canJump = false;
                if (_jumpCount < 3) {
                    Rb2D.AddForce(new Vector2(0, JumpSpeed), ForceMode2D.Impulse);
                }
            }
        }
    }
}
=======
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
>>>>>>> 3241bce9ca864982bd9e6441b0c6855965ec2937
