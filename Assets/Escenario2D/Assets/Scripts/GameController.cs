﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour {

    [Range (0f,0.20f)]
	public float parallaxSpeed = 0.02f;
	public RawImage background; 
	public RawImage plattaform;



	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		float finalSpeed = parallaxSpeed * Time.deltaTime; 
		background.uvRect = new Rect (background.uvRect.x + finalSpeed ,0f,1f,1f);
		plattaform.uvRect = new Rect (plattaform.uvRect.x + finalSpeed * 3 ,0f,1f,1f);

	}
}
