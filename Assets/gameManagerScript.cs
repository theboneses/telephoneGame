using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gameManagerScript : MonoBehaviour {

	public int playerNumber = 0;
	public int turnsTaken = 0;
	public string[] turnsOfPhrase; //honk honk wakka wakka, ugh im sorry

	public InputField numberInput;
	public textGeneratorScript textGen;
	void Awake() {
		DontDestroyOnLoad(transform.gameObject);
	}

	// Use this for initialization
	void Start () {
		numberInput = GameObject.FindObjectOfType<InputField> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void SetPlayerNumber(int playerNum){
		playerNumber = int.Parse(numberInput.text);
	}

	public void StartTurn(){
		string message = textGen.GenerateText;
		//TextToSpeechManager.SendTextToSpeech(message);
	}
}
