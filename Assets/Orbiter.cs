using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class Orbiter : MonoBehaviour 
{
	//---------------------------------------------------
	public Transform Pivot = null; // cube object
	private Transform ThisTransform = null;
	private Quaternion DestRot = Quaternion.identity;
	// Destination aka cube
	//Quaternion.Identiy meant 0 0 0 0 rotation on x and y axis

	//Distance to maintain from pivot
	public float PivotDistance = 5f; // dist between cube and capsule
	public float RotSpeed = 10f;
	private float RotX = 0f;
	private float RotY = 0f;
	//---------------------------------------------------
	void Awake()
	{
		ThisTransform = GetComponent<Transform>();
	}
	//---------------------------------------------------
	void Update()
	{
		float Horz = CrossPlatformInputManager.GetAxis("Horizontal"); // We use CrossPlat.. to read
		// input from keyboard

		float Vert = CrossPlatformInputManager.GetAxis("Vertical");

		RotX += Vert * Time.deltaTime * RotSpeed;
		RotY += Horz * Time.deltaTime * RotSpeed;

		Quaternion YRot = Quaternion.Euler(0f,RotY,0f);
		DestRot = YRot * Quaternion.Euler(RotX,0f,0f);

		ThisTransform.rotation = DestRot;

		//Adjust position, Maintaining distace between pivot and orbiter
		ThisTransform.position = Pivot.position + ThisTransform.rotation * Vector3.forward * -PivotDistance;
	}
	//---------------------------------------------------
}
//---------------------------------------------------