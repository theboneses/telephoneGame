using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class enterScreenScript : MonoBehaviour {

	public InputField stringInput;
	public Button enterButton;
	public gameManagerScript gamemgr;

	void Awake(){
		gamemgr = FindObjectOfType<gameManagerScript> ();
	}

	public void SetPhrase(){
		gamemgr.turnsOfPhrase.Add (stringInput.text);
	}
	public void NextTurn (){
		gamemgr.turnsTaken++;
		Instantiate (gamemgr.readScreenPrefab);
		Destroy(GameObject.Find("enter screen(Clone)"));

	}
}
