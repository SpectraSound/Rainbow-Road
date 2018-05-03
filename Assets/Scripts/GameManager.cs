using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    public Transform Player;
    private Transform StartPosition;


    void Start() {
        StartPosition.transform.position = Player.transform.position;
    }

	void Update() {

        Debug.Log(Player.transform.position.y);
	    if (Player.transform.position.y <= 0) {
	        Player.transform.position = StartPosition.transform.position;
	    }
	}


}
