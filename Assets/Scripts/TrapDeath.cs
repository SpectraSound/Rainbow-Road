using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapDeath : MonoBehaviour {

    public GameObject Player;
    private Vector3 startPosition;


    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
        startPosition = new Vector3(Player.transform.position.x, Player.transform.position.y, 0);

    }

    private void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.tag == "Player")
        {
            Player.transform.position = startPosition;
        }
    }

}
