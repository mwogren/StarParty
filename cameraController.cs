﻿using UnityEngine;
using System.Collections;

public class cameraController : MonoBehaviour
{
	public float rotationSpeed=0f;
	public float translationSpeed=0f;

	// Use this for initialization
	void Start ()
	{
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (Input.GetKey ("left")) 
			this.transform.Rotate (0f, -1.0f * rotationSpeed * Time.deltaTime,0f);
		
		if (Input.GetKey ("right")) 
			this.transform.Rotate (0f, rotationSpeed * Time.deltaTime,0f);
		
		if (Input.GetKey("up"))
			this.transform.Translate (Vector3.forward * Time.deltaTime * translationSpeed);  
		
		if (Input.GetKey("down"))
			this.transform.Translate (Vector3.forward * Time.deltaTime * translationSpeed * -1.0f); 

		/*if (Input.GetKey ("q")) 
			this.transform.Rotate (1.0f * rotationSpeed * Time.deltaTime, 0f, 0f);

		if (Input.GetKey ("w")) 
			this.transform.Rotate (-1.0f * rotationSpeed * Time.deltaTime, 0f, 0f);*/
	}
}
