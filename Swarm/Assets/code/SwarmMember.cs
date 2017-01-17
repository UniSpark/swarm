using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwarmMember : MonoBehaviour {

	private float thrust = 9.6f;
	private Rigidbody rb;
	private int verticalDistance;
	private ArrayList closestMembers;


	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
		rb.useGravity = true;
	}
	
	// Update is called once per frame
	void Update () {

		changeVector ();
		maintainFlight ();

	}

	// Alter x,y,z for this frame
	void changeVector()
	{

	}

	void maintainFlight()
	{
		rb.AddForce(0,thrust,0, ForceMode.Force);
	}
}
