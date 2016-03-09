using UnityEngine;
using System.Collections;

public class AnotherClass : MonoBehaviour 
	
{
	// Use this for initialization
	//void Start () {}
	// Update is called once per frame
	//void Update () {}
	
	public int apples;
	public int bananas;
	
	private int stapler;
	private int sellotape;
	
	
	public void FruitMachine (int a, int b)
	{
		int answer;
		answer = a + b;
		Debug.Log ("candy bar total: " + answer);
	}
	
	private void OfficeSort (int a, int b)
	{ 
		int answer;
		answer = a + b;
		Debug.Log ("candy bar Supplies total: " + answer);
	}
}

