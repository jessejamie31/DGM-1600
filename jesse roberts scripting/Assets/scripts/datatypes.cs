using UnityEngine;
using System.Collections;

public class datatypes : MonoBehaviour 
{

	// Use this for initialization
	void Start () 
	{
		//value type variable
		Vector3 pos = transform.position;
		pos = new Vector3 (1, 2, 3);

		//reference type variable
		Transform tran = transform;
		tran.position = new Vector3 (1, 2, 3);
	}
	
	// Update is called once per frame
	//void Update () {
	
}

