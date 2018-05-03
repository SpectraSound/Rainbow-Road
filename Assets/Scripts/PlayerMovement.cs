using UnityEngine;

namespace Assets.Scripts {
    public class PlayerMovement : MonoBehaviour {

        public int JumpSpeed = 5;

        private Rigidbody2D Rb2D;
        private bool canJump;
        public static int _jumpCount;

        void Start() {
            Rb2D = GetComponent<Rigidbody2D>();
        }

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