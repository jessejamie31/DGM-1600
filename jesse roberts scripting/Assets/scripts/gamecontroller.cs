using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class gamecontroller : MonoBehaviour {

	public Camera cam;
	public GameObject[]burgers;
	public float timeLeft;
	public Text timerText;
	public GameObject gameOverText;
	public GameObject restartButton;
	public GameObject healthy;
	public GameObject no;
	public GameObject start;


	private float maxWidth;
	private bool playing;

	void Start () {
		if (cam == null) {
			cam = Camera.main;
		}
		playing = false;
		Vector3 upperCorner = new Vector3 (Screen.width, Screen.height, 0.0f);
		Vector3 targetWidth = cam.ScreenToWorldPoint (upperCorner);
		float burgerWidth = burgers[0].GetComponent<Renderer>().bounds.extents.x;
		maxWidth = targetWidth.x - burgerWidth;
		}

	void FixedUpdate () {
		if (playing) {
			timeLeft -= Time.deltaTime;
			if (timeLeft < 0) {
				timeLeft = 0;
			}
		}
		timerText.text = "Time Left:\n" + Mathf.RoundToInt (timeLeft);
		}
	public void StartGame () {
		no.SetActive (false);
		start.SetActive (false);
		StartCoroutine (Spawn ());
	}

		IEnumerator Spawn () {
		yield return new WaitForSeconds (2.0f);
		playing = true;
		while (timeLeft > 0) {
			GameObject burger = burgers[Random.Range (0, burgers.Length)];
			Vector3 spawnPosition = new Vector3 (
					Random.Range (-5, 5),
					transform.position.y,
					0.0f
			);
			Quaternion spawnRotation = Quaternion.identity;
			Instantiate (burger, spawnPosition, spawnRotation);
			yield return new WaitForSeconds (Random.Range (1.0f, 2.0f));
		}
		yield return new WaitForSeconds (2.0f);
		gameOverText.SetActive (true);
		yield return new WaitForSeconds (2.0f);
		restartButton.SetActive (true);
	}
		void UpdateText () {
			timerText.text = "Time Left:\n" + Mathf.RoundToInt (timeLeft);
		}
}