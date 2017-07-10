using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class readScreenScript : MonoBehaviour {

	public Text hintText;
	public Button startTurn;
	public gameManagerScript gamemgr;
	private IEnumerator coroutine;

	void Awake(){
		gamemgr = FindObjectOfType<gameManagerScript> ();
		startTurn.onClick.AddListener (gamemgr.StartTimer);
	}

	public void SetHint(){
		if (gamemgr.turnsTaken == 0) {
			gamemgr.textGen.GenerateText ();
			hintText.text = gamemgr.turnsOfPhrase [gamemgr.turnsTaken];
		} else {
			hintText.text = gamemgr.turnsOfPhrase [gamemgr.turnsTaken];
		}
	}
	private IEnumerator WaitAndPrint(float waitTime)
	{
		while (true)
		{
			yield return new WaitForSeconds(waitTime);
			Instantiate (gamemgr.enterScreenPrefab);
			Destroy(GameObject.Find("read screen(Clone)"));
			//gameplay = GameObject.Find ("gameplay");
			//gameplay.GetComponentInChildren<Button> ().onClick.AddListener (SetPhrase);
			//gameplay.GetComponentInChildren<Button> ().onClick.AddListener (NextTurn);
			break;
		}


	}
	public void StartTimer(){
		coroutine = WaitAndPrint(5.0f);
		StartCoroutine(coroutine);
	}
	public void DisableButton(){
		startTurn.GetComponent<Button> ().interactable = false;
	}
}
