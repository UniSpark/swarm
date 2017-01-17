using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwarmMember : MonoBehaviour {

	private float thrust = 9.6f;
	private Rigidbody rb;
	private int verticalDistance;
	private float idealNeightorDistance = 100f;
	private float idealNeighborDistanceThreshold = 5f;

	// Each Member constantly triangulates with its closest 2 Members.
	private SwarmMember closestMember0;
	private SwarmMember closestMember1;


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

	public void addClostestMember(SwarmMember newMember)
	{

	}

	// Alter x,y,z for this frame
	void changeVector()
	{

	}

	bool isWithinDistanceThreshold(SwarmMember member)
	{
		//Vector3.Distance(rb.position, closestMember0.rb.position
	}

	// Stay equal distance from the closest 2 members and stay in the air.
	void maintainFlight()
	{
		// Check distnace between this and the first RigidBody
		if(isWithinDistanceThreshold(closestMember0))
		{

		}

		// Check distnace between this and the second RigidBody
		if(isWithinDistanceThreshold(closestMember1))
		{

		}

		// stay up
		rb.AddForce(0,thrust,0, ForceMode.Force);
	}
}
