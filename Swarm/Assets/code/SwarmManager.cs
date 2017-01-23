/**
 * This is a Swarming algorithm that controls virtual drones that carry a camera.
 * The drones are classed as SwarmMember.
 * This manager class adds and removes members and provides any global values into the greater algorithm.
 * The manager class tells each member where the central object wants to go and the swarm decides how to orient.
 * 
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwarmManager : MonoBehaviour {

	public ArrayList swarmList;

	private int targetInnerDistance = 100;

	private Vector3 direction;

	// Use this for initialization
	void Start () {
		swarmList = new ArrayList ();
		swarmList.Add (GameObject.Find("sphere0"));
		swarmList.Add (GameObject.Find("sphere1"));
		swarmList.Add (GameObject.Find("sphere2"));
		swarmList.Add (GameObject.Find("sphere3"));

	}

	public void setVector(Vector3 vector)
	{
		direction = vector;
	}

	void removeMember(SwarmMember member)
	{
		swarmList.Remove (member);
	}

	void addMember(SwarmMember member)
	{
		swarmList.Add (member);
	}

	public void takeOff()
	{

	}

	public void land()
	{

	}

	// Update is called once per frame
	void Update () {
		for (int i = 0; i <swarmList.Count; i++)
		{
			SwarmMember member = (SwarmMember)swarmList [i];
			member.transmitGlobalVector (direction);
		}
	}
		
}
