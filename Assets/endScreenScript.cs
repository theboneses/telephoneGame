using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class endScreenScript : MonoBehaviour {

	public Text initText;
	public Text endText;
	public gameManagerScript gamemgr;

	void Awake(){
		gamemgr = FindObjectOfType<gameManagerScript> ();
		initText.text = gamemgr.turnsOfPhrase [0];
		endText.text = gamemgr.turnsOfPhrase [gamemgr.turnsTaken];
		
	}
	public void StartOver(){
		SceneManager.LoadScene ("gameplaySketching");
	}
}
