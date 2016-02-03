using UnityEngine;
using System.Collections;

public class Ifstatement : MonoBehaviour 
{

	// Use this for initialization
	//void Start () 

	
	float hotcocoTemperature = 60.0f; 
	float hotLimitTemperature = 40.0f;
	float coldLimitTemperature = 30.0f;
	
	
	
	// Update is called once per frame
	void Update () 
	{
		if(Input.GetKeyDown(KeyCode.Space))
			TemperatureTest();
		
		hotcocoTemperature -= Time.deltaTime * 3f;
	}
	
	void TemperatureTest ()
	{
		// If the hotcoco's temperature is greater than the hottest drinking temperature...
		if(hotcocoTemperature > hotLimitTemperature)
		{
			// ... do this.
			print("hotcoco is too hot.");
		}
		// If it isn't, but the hotcoco's temperature is less than the coldest drinking temperature...
		else if(hotcocoTemperature < coldLimitTemperature)
		{
			// ... do this.
			print("hotcoco is too cold.");
		}
		// If it is neither of those then...
		else
		{
			// ... do this.
			print("hotcoco is just right.");
		}
		
	}
	}
	