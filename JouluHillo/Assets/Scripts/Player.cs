using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour {

    [SerializeField]
    int MaxVitamin;
    [SerializeField]
    int MinVitamin;
    public float VitaA;
    public float VitaB;
    public float VitaC;
    [SerializeField]
    Image VitaABarImg;
    [SerializeField]
    Image VitaBBarImg;
    [SerializeField]
    Image VitaCBarImg;
    [SerializeField]
    Sprite VitaABarSprite;
    [SerializeField]
    Sprite VitaBBarSprite;
    [SerializeField]
    Sprite VitaCBarSprite;
    [SerializeField]
    Sprite VitaGreyBarSprite;
    [SerializeField]
    Slider VitaminABar;
    [SerializeField]
    Slider VitaminBBar;
    [SerializeField]
    Slider VitaminCBar;
    [SerializeField]
    int VitaminConsumption;
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
        VitaminABar.value = 100 - VitaA;
        VitaA = Mathf.Clamp(VitaA, MinVitamin, MaxVitamin);
        VitaminBBar.value = 100 - VitaB;
        VitaB = Mathf.Clamp(VitaB, MinVitamin, MaxVitamin);
        VitaminCBar.value = 100 - VitaC;
        VitaC = Mathf.Clamp(VitaC, MinVitamin, MaxVitamin);

        if (VitaA <= 20f)
        {
            VitaABarImg.sprite = VitaGreyBarSprite;
        }
        else
        {
            VitaABarImg.sprite = VitaABarSprite;
        }
        if (VitaB <= 20f)
        {
            VitaBBarImg.sprite = VitaGreyBarSprite;
        }
        else
        {
            VitaBBarImg.sprite = VitaBBarSprite;
        }
        if (VitaC <= 20f)
        {
            VitaCBarImg.sprite = VitaGreyBarSprite;
        }
        else
        {
            VitaCBarImg.sprite = VitaCBarSprite;
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
        VitaA -= VitaminConsumption * Time.deltaTime;
        VitaB -= VitaminConsumption * Time.deltaTime;
        VitaC -= VitaminConsumption * Time.deltaTime;
    }

}
