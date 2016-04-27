using UnityEngine;
using System.Collections;

public class restart : MonoBehaviour {
	public void RestartGame () {
		Application.LoadLevel (Application.loadedLevel);
	}
}
