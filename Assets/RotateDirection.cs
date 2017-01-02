using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateDirection : MonoBehaviour {

	private Transform ThisTransform = null;
	public float RotSpeed = 90f;

	public Transform Target = null;

	// Use this for initialization
	void Start () {
		ThisTransform = GetComponent<Transform>();
	}
	
	// Update is called once per frame
	void Update () {
		Quaternion DestRot = Quaternion.LookRotation(Target.position - ThisTransform.position, 
			Vector3.up);

		ThisTransform.rotation = Quaternion.RotateTowards (ThisTransform.rotation, DestRot, RotSpeed * Time.deltaTime);

		// Here we can control relative speed of capsule with respect to moving cube.
		//Instructor says it helps to enhance realism of your levels
	}
}
