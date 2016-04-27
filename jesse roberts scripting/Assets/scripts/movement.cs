using UnityEngine;
using System.Collections;

public class movement : MonoBehaviour {

	public Camera cam;
	
	private float maxWidth;
	
	// Use this for initialization
	void Start () {
		if (cam == null) {
			cam = Camera.main;
		}
		Vector3 upperCorner = new Vector3 (Screen.width, Screen.height, 0.0f);
		Vector3 targetWidth = cam.ScreenToWorldPoint (upperCorner);
		float guyWidth = GetComponent<Renderer>().bounds.extents.x;
		maxWidth = targetWidth.x;
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		Vector3 rawPosition = cam.ScreenToWorldPoint (Input.mousePosition);
		Vector3 targetPostition = new Vector3 (rawPosition.x, 0.0f, 0.0f);
		float targetWidth = Mathf.Clamp (targetPostition.x, -maxWidth, maxWidth);
		targetPostition = new Vector3 (targetWidth, targetPostition.y, targetPostition.z);
		GetComponent<Rigidbody2D>().MovePosition (targetPostition);
		
	}
}
