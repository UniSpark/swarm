using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwarmMember : MonoBehaviour {

	private Vector3 thrust;
	private Rigidbody rb;
	private int verticalDistance;
	private ArrayList closestMembers;


	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
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
		rb.velocity = Vector3.zero;
		rb.AddForce (new Vector3 (1, 1));
	}
}
