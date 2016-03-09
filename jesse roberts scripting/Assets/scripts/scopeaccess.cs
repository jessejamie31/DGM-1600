using UnityEngine;
using System.Collections;

public class scopeaccess : MonoBehaviour 
{
	public int snickers = 5;

	private int kitkat = 0;
	private int milkyway = 5;


	private AnotherClass myOtherClass;

	void Start () 
	{
		snickers = 29;

		myOtherClass = new AnotherClass();
		myOtherClass.FruitMachine(snickers, myOtherClass.apples);
	}

	void Example (int pens, int crayons)
	{
		int answer;
		answer = pens * crayons * snickers;
		Debug.Log(answer);
	}

	void Update () 
	{
		Debug.Log("snickers is set to; " + snickers);
	}

}