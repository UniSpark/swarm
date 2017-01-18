/**
 * This class is the instance of drone that provides lift to a central object.
 * Each SwarmMember keeps track of the 2 closest members and maintains a predefined distance between it and them.
 * The onFixedUpdate method triggers the calculations that arrange groups into triangles.
 * The triangles are the basis of the grid that the SwarmMembers take as time progresses.  
 * The distance between them depends on the total number of members and is controlled globally.
 * 
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwarmMember : MonoBehaviour {

	private float gravity = 9.8f;
	private Vector3 thrustVector;
	private Rigidbody rb;
	private int verticalDistance;

	// This is the intial value for how much distance between neighbors but gets updated by the manager class if more members are added.
	private float idealNeightorDistance = 100f;

	// This provides padding for distance between neighbors.
	private float idealNeighborDistanceThreshold = 5f;

	// Each Member constantly triangulates with its closest 2 Members.
	private SwarmMember closestMember0;
	private SwarmMember closestMember1;

	// These are the data structures that add up to form the end vector for each frame
	private Vector3 localThrustVector0;
	private Vector3 localThrustVector1;
	private Vector3 globalThrustVector;

	void Start () {
		rb = GetComponent<Rigidbody> ();
		rb.useGravity = true;
		thrustVector.y = gravity;
	}

	void onFixedUpdate() {
		assignLocalTrajectory ();
		updateGlobalVector ();
	}

	// Update is called once per frame
	void Update () {

		// move
		rb.AddForce(thrustVector.x, 0, thrustVector.z, ForceMode.Force);
	}

	// Gets called from SwarmManager
	void updateIdealNeighborDistance(float value)
	{
		idealNeightorDistance = value;
	}

	/**
	 * Figure out which neighbor needs to be replaced
	 */
	public void addClosestMember(SwarmMember member)
	{
		float newMemberDistance = Vector3.Distance (rb.position, member.rb.position);
		if (Vector3.Distance (rb.position, closestMember0.rb.position) < newMemberDistance) {
			closestMember1 = member;
		} else {
			closestMember0 = member;

		}

	}

	/**
	 * This lets the manager send updates to ensure this part of the swarm moves the central object
	 */
	public void transmitGlobalVector(Vector3 vector) 
	{

	}

	/** 
	 * This takes any global data from last frame and mixes it into the vector in the next frame after traingulation
	 * 
	 */
	void updateGlobalVector()
	{
		
	}

	/**
	 * Sets the vector between this RigidBody and the one passed in as a parameter
	 * 
	 */
	Vector3 setVector(SwarmMember member)
	{
		Vector3 direction = (member.rb.position - rb.position).normalized;
		Vector3 newDirection;

		if (Vector3.Distance (rb.position, member.rb.position) < idealNeightorDistance - idealNeighborDistanceThreshold) {

			newDirection = transform.position + direction;
		}
		if (Vector3.Distance (rb.position, member.rb.position) > idealNeightorDistance + idealNeighborDistanceThreshold) {

			newDirection = transform.position - direction;
				
		}

		return newDirection;
	}

	/**
	 * Stay equal distance from the closest 2 members.
	 */
	void assignLocalTrajectory()
	{
		localThrustVector0 = setVector (closestMember0);
		localThrustVector1 = setVector (closestMember1);
	}
}
