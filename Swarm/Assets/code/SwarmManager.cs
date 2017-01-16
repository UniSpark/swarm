using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwarmManager : MonoBehaviour {

	public ArrayList swarmList;

	private int targetInnerDistance = 100;

	// Use this for initialization
	void Start () {
		swarmList = new ArrayList ();
	}

	void removeMember(SwarmMember member)
	{
		swarmList.Remove (member);
	}

	void addMember(SwarmMember member)
	{
		swarmList.Add (member);
	}
	
	// Update is called once per frame
	void Update () {
		for (uint i = 0; i <swarmList.Count; i++)
		{
			
		}
	}
		
}
