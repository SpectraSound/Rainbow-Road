using System.Collections;
using System.Collections.Generic;
using UnityEngine;
#pragma warning disable 169

public class FollowPlayer : MonoBehaviour {

    public GameObject Player;

    public float offsetY;

    public float speed = 1.0F;
    private float startTime;
    private float journeyLength;
    private Vector3 velocity = Vector3.zero;
    void Start()
    {
        startTime = Time.time;
        journeyLength = Vector3.Distance(transform.position, Player.transform.position);
    }
    void FixedUpdate()
    {
        float distCovered = (Time.time - startTime) * speed;
        float fracJourney = distCovered / journeyLength;
        float testTime = speed * Time.deltaTime;
        transform.position = Vector3.SmoothDamp(transform.position, new Vector3(Player.transform.position.x, Player.transform.position.y, -10f), ref velocity, testTime);
    }



    //	// Update is called once per frame
    //	void Update () {
    //	    offsetY = Player.transform.position.y - transform.position.y;
    //	    offsetX = Player.transform.position.x - transform.position.x;
    //        _followPlayer();
    //	}
    //
    //    public void _followPlayer() {
    //        if (transform.position != Player.transform.position) {
    //            transform.Translate(offsetX, 0, 0);
    //        }
    //    }

}
