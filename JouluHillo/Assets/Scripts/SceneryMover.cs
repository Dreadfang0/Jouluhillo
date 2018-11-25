using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneryMover : MonoBehaviour {

    private Rigidbody2D rb2d;
    float SetPieceLenght;

    [SerializeField]
    float speed = 1f;

    // Use this for initialization
    void Start()
    {
        SetPieceLenght = GetComponent<SpriteRenderer>().bounds.size.x / 4;
        rb2d = GetComponent<Rigidbody2D>();
        rb2d.velocity = new Vector2(-speed, 0);
    }

    void Update()
    {
        if (transform.position.x < -SetPieceLenght)
        {
            Vector2 groundOffSet = new Vector2(SetPieceLenght * 2f, 0);
            //transform.position = (Vector2)transform.position.x groundOffSet;
            transform.position = new Vector3((transform.position.x + groundOffSet.x), transform.position.y, transform.position.z);

        }
    }
}
