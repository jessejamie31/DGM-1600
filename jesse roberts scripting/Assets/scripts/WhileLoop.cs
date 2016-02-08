using UnityEngine;
using System.Collections;

public class WhileLoop : MonoBehaviour 
{
	int civiliansToSave = 3;
	
	// Use this for initialization
	void Start () 
	{
		while(civiliansToSave > 0)
		{
			Debug.Log ("You've saved a civilian!");
			civiliansToSave--;
		}
		
		// Update is called once per frame
		//void Update () {
		
	}
}


