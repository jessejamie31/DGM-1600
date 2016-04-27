using UnityEngine;
using System.Collections;

public class Conversation : MonoBehaviour 
{
	public int intelligence = 5;

	void Greet()
	{
		switch (intelligence) {
		case 5:
			print ("hey");
			break;
		case 4:
			print ("hello");
			break;
		case 3:
			print ("what");
			break;
		case 2:
			print ("yeah");
			break;
		case 1:
			print ("yup");
			break;
		default:
			print ("Incorrect intelligence level.");
			break;
		}
	}
}
