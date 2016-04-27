using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class score : MonoBehaviour {

	public Text scoreText;
	public int burgerValue;

	private int Score;

	// Use this for initialization
	void Start () {
		Score = 0;
		UpdateScore ();
	}

	void OnTriggerEnter2D () {
		Score += burgerValue;
		UpdateScore ();
	}
	void OnCollisionEnter2D(Collision2D collision)	{
		if (collision.gameObject.tag == "healthy") {
			Score -= burgerValue * 2;
		}
		}
	

	// Update is called once per frame
	void UpdateScore () {
		scoreText.text = "Score:\n" + Score;
	
	}
}
