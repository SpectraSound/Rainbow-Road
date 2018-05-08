using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

<<<<<<< HEAD
/*    public GameObject player;
    private Vector3 startPosition;

    void Start()
    {
        startPosition = new Vector3(player.transform.position.x, player.transform.position.y, 0);
    }

    // Update is called once per frame
    void Update()
    {
        Reset();
    }

    private void Reset()
    {
        if (player.transform.position.y <= -3f)
        {
            player.transform.position = startPosition;
        }
    }*/
=======
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

>>>>>>> aa0468f2fb930c162432f639c5547820015461ee

}
