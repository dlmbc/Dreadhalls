using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelTracker : MonoBehaviour {
	
	public static int level = 1;

	public Text levelText;
	
	// Use this for initialization
	void Start () {
		levelText.text = "LEVEL " + level.ToString();
	}
	
	// Update is called once per frame
	void Update () {

	}
}