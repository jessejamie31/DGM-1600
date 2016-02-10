using UnityEngine;
using System.Collections;

public class Foreachloop : MonoBehaviour 
{

	// Use this for initialization
	void Start () 
	{
		string[] strings = new string[2];

		strings[0] = "First string";
		strings[1] = "Second string";
	

		foreach(string item in strings)
		{
			print (item);
		}
	
	// Update is called once per frame
	//void Update () {
	
	}
}
