using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VitaminHandler : MonoBehaviour {

    public bool VitaminA;
    public bool VitaminB;
    public bool VitaminC;
    public Sprite VitaminASprite;
    public Sprite VitaminBSprite;
    public Sprite VitaminCSprite;
    public int VitaValue;
    // Use this for initialization
    void Start ()
    {
        int r = Random.Range(1, 4) ;
        if (r == 1)
        {
            VitaminA = true;
            gameObject.GetComponent<SpriteRenderer>().sprite = VitaminASprite;
        }
        if (r == 2)
        {
            VitaminB = true;
            gameObject.GetComponent<SpriteRenderer>().sprite = VitaminBSprite;
        }
        if (r == 3)
        {
            VitaminC = true;
            gameObject.GetComponent<SpriteRenderer>().sprite = VitaminCSprite;
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            if (VitaminA == true)
            {
                collision.GetComponent<Player>().VitaA += VitaValue;
            }
            if (VitaminB == true)
            {
                collision.GetComponent<Player>().VitaB += VitaValue;
            }
            if (VitaminC == true)
            {
                collision.GetComponent<Player>().VitaC += VitaValue;
            }
        }
    }
}
