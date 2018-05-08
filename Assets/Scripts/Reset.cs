using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reset : MonoBehaviour {

    public GameObject Player;
    private Vector3 startPosition;
    public float offsetY = -5f;
    public float offsetX;
    

    void Start()
    {
        startPosition = new Vector3(Player.transform.position.x, Player.transform.position.y, 0);

    }

    	// Update is called once per frame
    	void Update () {
    	    
    	    offsetX = Player.transform.position.x - transform.position.x;
            _followPlayer();
    	}
    
        public void _followPlayer() {
            if (transform.position != Player.transform.position) {
                transform.Translate(offsetX, 0, 0);
            }
        }


    private void OnTriggerEnter2D(Collider2D coll) {
        if (coll.tag == "Player") {
            Player.transform.position = startPosition;
        }
    }
}
