using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileMover : MonoBehaviour {

    public float ScrollSpeed;
    GameObject player;
	// Use this for initialization
	void Awake ()
    {
        player = GameObject.FindWithTag("Player");
        
	}
	
	// Update is called once per frame
	void FixedUpdate ()
    {
        ScrollSpeed = player.GetComponent<Player>().Speed;
        transform.Translate(ScrollSpeed, 0 ,0);
	}
}
