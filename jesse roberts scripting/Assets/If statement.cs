using UnityEngine;
using System.Collections;

public class If statement : MonoBehaviour 
{

	// Use this for initialization
	//void Start () {

	float coffeeTemperature = 85.0f; 
	float hotLimitTemperature = 70.0f;
	float coldLimitTemperature = 40.0f;
	

	
	// Update is called once per frame
	void Update () 
   {
	  if(Input.GetKeyDown(KeyCode.Space))
		  TemperatureTest();

	  coffeeTemperature -= Time.deltaTime * 5f;
   }

 void TemperatureTest ()
 {
	// If the coffee's temperature is greater than the hottest drinking temperature...
	if(coffeeTemperature > hotLimitTemperature)
	{
		// ... do this.
		print("Coffee is too hot.");
	}
	// If it isn't, but the coffee temperature is less than the coldest drinking temperature...
	else if(coffeeTemperature < coldLimitTemperature)
	{
		// ... do this.
		print("Coffee is too cold.");
	}
	// If it is neither of those then...
	else
	{
		// ... do this.
		print("Coffee is just right.");
	}

 }

}
