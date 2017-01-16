using System;
using UnityEngine;

namespace AssemblyCSharp
{
	public class SwarmUtils
	{
		static float calcDistance(Rigidbody object1, Rigidbody object2)
		{
			return Vector3.Distance(object1.transform.position, object2.transform.position);
		}
	}
}

