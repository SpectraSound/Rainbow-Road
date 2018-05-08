using UnityEngine;

namespace Assets.Scripts {
    public class Grounder : MonoBehaviour {

        // Use this for initialization
        void Start () {
		
        }
	
        // Update is called once per frame
        void Update () {
            //Debug.Log(PlayerMovement._jumpCount);
        }

        private void OnTriggerEnter2D(Collider2D other) {
            if (other.tag == "Player") {
                ResetCounter();
            }
        }

        public void ResetCounter() {
            PlayerMovement._jumpCount = 0;
        }
    }
}
