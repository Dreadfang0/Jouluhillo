using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    public int VitaA;
    public int VitaB;
    public int VitaC;

    bool IsGrounded = false;
    Rigidbody2D rb2D;

    [SerializeField]
    float JumpForce;

	// Use this for initialization
	void Start ()
    {
        rb2D = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update ()
    {
     
		if(Input.GetKeyDown("space") && IsGrounded == true)
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, JumpForce));
            IsGrounded = false;
        }      
	}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Ground")
        {
            IsGrounded = true;
        }
    }

    private void FixedUpdate()
    {
        //Debug.DrawLine(new Vector2(transform.position.x, transform.position.y), new Vector2(0,0));
        //RaycastHit2D GroundTrigger = Physics2D.BoxCast(new Vector2(transform.position.x, transform.position.y), new Vector2(1,1), 0f, new Vector2(0, -2));
    }

}
