using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour {

    float NormSpeed;
    float OverdoseSpeed;
    public float Speed;
    [SerializeField]
    int MaxVitamin;
    [SerializeField]
    int MinVitamin;
    public float VitaA;
    public float VitaB;
    public float VitaC;
    [SerializeField]
    SpriteRenderer HeadRender;

    [SerializeField]
    Sprite HeadHappy;
    [SerializeField]
    Sprite HeadPuke;
    [SerializeField]
    Sprite HeadTooth;
    [SerializeField]
    Sprite HeadSkull;
    [SerializeField]
    Sprite HeadSad;

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
    GameObject Fire;
    [SerializeField]
    GameObject Shit;
    [SerializeField]
    GameObject Vomit;
    [SerializeField]
    GameObject Teeth;
    [SerializeField]
    GameObject Skin;
    
    [SerializeField]
    float JumpForce;

	// Use this for initialization
	void Start ()
    {
        NormSpeed = Speed;
        OverdoseSpeed = Speed * 2;
        rb2D = GetComponent<Rigidbody2D>();
	}

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown("space") && IsGrounded == true)
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
            
            HeadRender.sprite = HeadSad;
            Debug.Log("yeet!");
            Skin.SetActive(false);
            //apply Deficiency effect and whatnot
        }
        if (VitaA >= 80)
        {
            HeadRender.sprite = HeadSkull;
            Skin.SetActive(true);
        }
        else if (VitaA >= 20)
        {
            //Deficiency gone
            VitaABarImg.sprite = VitaABarSprite;
            if (VitaA <= 80)
            {
                Skin.SetActive(false);
            }
            
        }
        if (VitaB <= 20f)
        {
            VitaBBarImg.sprite = VitaGreyBarSprite;
            HeadRender.sprite = HeadSad;
            Fire.SetActive(true);
            Shit.SetActive(false);
            Vomit.SetActive(false);

        }
        if (VitaB >= 80)
        {
            HeadRender.sprite = HeadPuke;
            Shit.SetActive(true);
            Vomit.SetActive(true);
            Fire.SetActive(false);
        }
        else if (VitaB >= 20)
        {
            VitaBBarImg.sprite = VitaBBarSprite;
            Shit.SetActive(false);
            Vomit.SetActive(false);
            if (VitaB <= 80)
            {
                Fire.SetActive(false);
                
            }
        }
        if (VitaC <= 20f)
        {
            VitaCBarImg.sprite = VitaGreyBarSprite;
            HeadRender.sprite = HeadTooth;
            Teeth.SetActive(true);
            
        }
        if (VitaC >= 80)
        {
            Speed = OverdoseSpeed;
            //Apply Sanic Theme
        }
        
        else if (VitaC >= 20)
        {
            VitaCBarImg.sprite = VitaCBarSprite;
            Speed = NormSpeed;
            Teeth.SetActive(false);
        }
        if (VitaA >= 20 && VitaB >= 20 && VitaC >= 20 && VitaA <= 80 && VitaB <= 80 )
        {
            HeadRender.sprite = HeadHappy;
        }
        if (VitaA == 0 || VitaB == 0 || VitaC == 0 || VitaA == 100 || VitaB == 100)
        {
            
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
