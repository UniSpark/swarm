using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwarmMember : MonoBehaviour {

	private float gravity = 9.8f;
	private Vector3 thrustVector;
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
		thrustVector.y = gravity;
	}

	void onFixedUpdate() {
		
		changeVector ();
		maintainFlight ();
	}

	// Update is called once per frame
	void Update () {

		// stay up
		rb.AddForce(0,thrustVector.y,0, ForceMode.Force);
	}

	public void addClostestMember(SwarmMember newMember)
	{

	}

	// Alter x,y,z for this frame
	void changeVector()
	{

	}
	//TODO changing this to method that alters the trajectory for triangulation
	bool isWithinDistanceThreshold(SwarmMember member)
	{
		Vector3 direction = (member.rb.position - rb.position).normalized;
		if (Vector3.Distance (rb.position, member.rb.position) < idealNeightorDistance - idealNeighborDistanceThreshold) {

			thrustVector = transform.position + direction
			//rigidbody.MovePosition(transform.position + direction * movementSpeed * Time.deltaTime);
			//return false;
		}
		if (Vector3.Distance (rb.position, member.rb.position) > idealNeightorDistance + idealNeighborDistanceThreshold) {
			return false;
		}

		return true;
	}

	// Stay equal distance from the closest 2 members.
	void assignLocalTrajectory()
	{
		// Check distnace between this and the first RigidBody
		if(!isWithinDistanceThreshold(closestMember0))
		{

		}

		// Check distnace between this and the second RigidBody
		if(isWithinDistanceThreshold(closestMember1))
		{

		}


	}
}
