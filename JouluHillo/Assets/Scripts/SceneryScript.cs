﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneryScript : MonoBehaviour {

	// Use this for initialization
	void Start ()
    {

	}
	
	// Update is called once per frame
	void Update ()
    {
        this.transform.position = transform.position + new Vector3(-0.01f, 0, 0);	
	}
}
