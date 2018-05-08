using UnityEngine;

namespace Assets.Scripts {
    public class Grounder : MonoBehaviour {

        // Use this for initialization
        void Start () {
		
        }
	
        // Update is called once per frame
        void Update () {
<<<<<<< HEAD
            //Debug.Log(PlayerMovement._jumpCount);
=======
>>>>>>> aa0468f2fb930c162432f639c5547820015461ee
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
