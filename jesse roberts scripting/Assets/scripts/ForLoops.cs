using UnityEngine;
using System.Collections;

public class ForLoops : MonoBehaviour 
{
	int numBadguys = 4;

	void Start ()
	{
		for(int i = 0; i < numBadguys; i++)
		{
			Debug.Log("Creating Badguy number: " + i);
		}
	// Update is called once per frame
	//void Update () 
	}

}
