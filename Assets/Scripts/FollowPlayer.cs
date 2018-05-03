using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour {

    public GameObject Player;

    private float offsetY;

    private float offsetX;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	    offsetY = Player.transform.position.y - transform.position.y;
	    offsetX = Player.transform.position.x - transform.position.x;
        _followPlayer();
	}

    public void _followPlayer() {
        if (transform.position != Player.transform.position) {
            transform.Translate(offsetX, 0, 0);
        }
    }

}
