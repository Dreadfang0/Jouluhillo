using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		if(Input.GetKey("up"))
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 15));
            Debug.Log("pressed up");
        }

        if(Input.GetKey("right"))
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(10,0));
        }
	}
}
