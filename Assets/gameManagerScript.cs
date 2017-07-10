using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class gameManagerScript : MonoBehaviour {

	public int playerNumber = 0;
	public int turnsTaken = 0;
	public List<string> turnsOfPhrase; //honk honk wakka wakka, ugh im sorry

	//public float timeLeft = 5.0f;

	public InputField numberInput;
	public string message;

	public GameObject startScreenPrefab;
	public GameObject readScreenPrefab;
	public GameObject enterScreenPrefab;
	public GameObject endScreenPrefab;

	public textGeneratorScript textGen;
	public Text hintText;
	public GameObject gameplay;


	private IEnumerator coroutine;


	// Use this for initialization
	void Start () {
		numberInput = GameObject.FindObjectOfType<InputField> ();
	}
	void Update(){
		
		if (playerNumber != 0 && turnsTaken==playerNumber ) {
			Instantiate (endScreenPrefab);
			Destroy(GameObject.Find("enter screen(Clone)"));
			playerNumber = 0;
			Destroy(GameObject.Find("read screen(Clone)"));
		}
	}

	public void SetPlayerNumber(int playerNum){
		playerNumber = int.Parse(numberInput.text);

	}

	public void StartTurn(){
		Instantiate (readScreenPrefab);
		Destroy(GameObject.Find("start screen"));
		Destroy(GameObject.Find("enter screen(Clone)"));
	}


	public void SetHint(){
		hintText.text = turnsOfPhrase[ turnsTaken ];
	}

	private IEnumerator WaitAndPrint(float waitTime)
	{
		while (true)
		{
			yield return new WaitForSeconds(waitTime);
			Instantiate (enterScreenPrefab);
			Destroy(GameObject.Find("read screen(Clone)"));

			break;
		}


	}
	public void StartTimer(){
		coroutine = WaitAndPrint(3.0f);
		StartCoroutine(coroutine);
	}

}
