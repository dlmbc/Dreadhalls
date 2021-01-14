using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DespawnOnHeight : MonoBehaviour {
	public GameObject characterController;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		if (gameObject.transform.position.y < 0) {
			Destroy(GameObject.Find("WhisperSource"));
			LevelTracker.level = 1; // reset level to 1
			SceneManager.LoadScene("GameOver");
		}
	}
}