using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour {

    public GameObject Player;

    private float _offsetY;

    private float _offsetX;
    


	void Update () {
	    _offsetY = Player.transform.position.y - transform.position.y;
	    _offsetX = Player.transform.position.x - transform.position.x;
        _followPlayer();
	}

    public void _followPlayer() {
        if (transform.position != Player.transform.position) {
            transform.Translate(_offsetX, 0, 0);
        }
    }

}
