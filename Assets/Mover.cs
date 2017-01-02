using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour {

	public float MaxSpeed = 1f; 
	//measured in terms of meters per second

	private Transform ThisTransform = null; 
	// Created reference var to the
	// transform component attached to captured object, so that we can access
	// position va and adjust speed of the object

	// Use this for initialization
	void Start () {

		ThisTransform = GetComponent<Transform> ();
		// we use GetComponent to retrieve any specific component
		
	}
	
	// Update is called once per frame
	void Update () {

		//ThisTransform.position += ThisTransform.forward * MaxSpeed;

		ThisTransform.position += ThisTransform.forward * -MaxSpeed * Time.deltaTime;
		// Used this to move in opposite direction of blue arrow or z axis
		// Time is constant in all machines and multiplying it with delta time
		//makes the GameObject move constantly across all machines
	}
}
