﻿using UnityEngine;

namespace Assets.Scripts {
    public class PlayerMovement : MonoBehaviour {
        
        public static int _jumpCount;

        public int JumpSpeed = 5;

        private Rigidbody2D Rb2D;

        private bool canJump;
        
        public float MoveSpeed;

    
        void Start() {
            Rb2D = GetComponent<Rigidbody2D>();
        }
        
<<<<<<< HEAD
        void FixedUpdate() {

            
        }
=======

>>>>>>> aa0468f2fb930c162432f639c5547820015461ee

        void Update() {
            PlayerMove();
            PlayerJump();
        }

        void PlayerJump() {



            if (canJump) {
                canJump = false;
                if (_jumpCount < 3) {
                    Rb2D.AddForce(new Vector2(0, JumpSpeed), ForceMode2D.Impulse);
                }
            }
        }
        public void PlayerMove() {
            if (Input.GetKey(KeyCode.D)) {
                Rb2D.AddForce(new Vector2(MoveSpeed,0));
            }

            if (Input.GetKey(KeyCode.A)) {
                Rb2D.AddForce(new Vector2(-MoveSpeed, 0));
            }

            if (Input.GetKeyDown(KeyCode.W))
            {
                canJump = true;
                _jumpCount++;
            }

        }
    }
}

