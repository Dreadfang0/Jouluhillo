using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileMover : MonoBehaviour {

    public float ScrollSpeed;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate ()
    {
        transform.Translate(ScrollSpeed, 0 ,0);
	}
}
