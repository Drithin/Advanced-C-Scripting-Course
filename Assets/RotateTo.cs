using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateTo : MonoBehaviour {

	private Transform ThisTransform = null;
	public float RotSpeed = 900f;

	// Use this for initialization
	void Start () {

		ThisTransform = GetComponent<Transform>();
	}
	
	// Update is called once per frame
	void Update () {

		//ThisTransform.rotation *= Quaternion.AngleAxis (RotSpeed * Time.deltaTime, Vector3.up);

		ThisTransform.rotation *=  Quaternion.AngleAxis (RotSpeed * Time.deltaTime, Vector3.up);
	}
}
