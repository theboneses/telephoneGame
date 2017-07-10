using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class textGeneratorScript : MonoBehaviour {

	public List<string> listOfVerbs;
	public List<string> listOfAdjectives;
	public List<string> listOfNouns;
	public List<string> listOfPrepositions;
	public List<string> listOfPossessives;

	public string answer;
	public gameManagerScript gameMgr;
	//public Button butt;

	void Awake(){
		gameMgr = FindObjectOfType<gameManagerScript> ();
		gameMgr.textGen = this;
	//	butt = FindObjectOfType<Button> ();
	//	butt.onClick.AddListener (GenerateText);
		//hintText = GameObject.FindGameObjectWithTag ("hint");
	}
	void Start(){
		listOfAdjectives.Add ("shiny");
		listOfAdjectives.Add ("exotic");
		listOfAdjectives.Add ("funny");
		listOfAdjectives.Add ("bright");
		listOfAdjectives.Add ("radical");
		listOfAdjectives.Add ("entropic");
		listOfAdjectives.Add ("regimented");
		listOfAdjectives.Add ("tired");
		listOfAdjectives.Add ("happy");
		listOfAdjectives.Add ("giddy");
		listOfAdjectives.Add ("onerous");
		listOfAdjectives.Add ("silly");
		listOfAdjectives.Add ("smelly");
		listOfAdjectives.Add ("drunk");
		listOfAdjectives.Add ("dry");
		listOfAdjectives.Add ("dusty");
		listOfAdjectives.Add ("energetic");
		listOfAdjectives.Add ("myopic");
		listOfAdjectives.Add ("friendly");
		listOfAdjectives.Add ("frightening");
		listOfAdjectives.Add ("forgettable");
		listOfAdjectives.Add ("beautiful");
		listOfAdjectives.Add ("ginormous");
		listOfAdjectives.Add ("gigantic");
		listOfAdjectives.Add ("dependent");
		listOfAdjectives.Add ("quick");
		listOfAdjectives.Add ("brown");
		listOfAdjectives.Add ("lazy");

		listOfNouns.Add ("apple");
		listOfNouns.Add ("car");
		listOfNouns.Add ("caramel");
		listOfNouns.Add ("apartment");
		listOfNouns.Add ("intention");
		listOfNouns.Add ("coffee mug");
		listOfNouns.Add ("cotton candy");
		listOfNouns.Add ("tennis court");
		listOfNouns.Add ("primary source");
		listOfNouns.Add ("motorcycle");
		listOfNouns.Add ("medication");
		listOfNouns.Add ("invention");
		listOfNouns.Add ("miasma");
		listOfNouns.Add ("body parts");
		listOfNouns.Add ("clause");
		listOfNouns.Add ("causes");
		listOfNouns.Add ("santa claus");
		listOfNouns.Add ("movies");
		listOfNouns.Add ("crevasse");
		listOfNouns.Add ("fox");
		listOfNouns.Add ("dog");
		listOfNouns.Add ("fly");
		listOfNouns.Add ("buffalo");
		listOfNouns.Add ("new york city");
		listOfNouns.Add ("space needle");
		listOfNouns.Add ("crash");

		listOfVerbs.Add ("invent");
		listOfVerbs.Add ("bake");
		listOfVerbs.Add ("chase");
		listOfVerbs.Add ("sneeze");
		listOfVerbs.Add ("interfere");
		listOfVerbs.Add ("play");
		listOfVerbs.Add ("prepare");
		listOfVerbs.Add ("continue");
		listOfVerbs.Add ("expect");
		listOfVerbs.Add ("remind");
		listOfVerbs.Add ("fart");
		listOfVerbs.Add ("dissect");
		listOfVerbs.Add ("rewind");
		listOfVerbs.Add ("expend");
		listOfVerbs.Add ("balk");
		listOfVerbs.Add ("invite");
		listOfVerbs.Add ("crash");
		listOfVerbs.Add ("jump");
		listOfVerbs.Add ("fly");

		listOfPrepositions.Add ("to");
		listOfPrepositions.Add ("around");
		listOfPrepositions.Add ("on");
		listOfPrepositions.Add ("following");
		listOfPrepositions.Add ("after");
		listOfPrepositions.Add ("before");
		listOfPrepositions.Add ("under");
		listOfPrepositions.Add ("beside");
		listOfPrepositions.Add ("instead of");
		listOfPrepositions.Add ("while");
		listOfPrepositions.Add ("into");

		listOfPossessives.Add ("a");
		listOfPossessives.Add ("the");
		listOfPossessives.Add ("your");
		listOfPossessives.Add ("my");
		listOfPossessives.Add ("his");
		listOfPossessives.Add ("her");
		listOfPossessives.Add ("our");
		listOfPossessives.Add ("their");


	}

	public void GenerateText(){
		string verb = listOfVerbs[Random.Range(0, listOfVerbs.Count)];
		string adjective = listOfAdjectives[Random.Range(0, listOfAdjectives.Count)];
		string noun = listOfNouns[Random.Range(0, listOfNouns.Count)];
		string transitiveVerb = listOfVerbs [Random.Range (0, listOfNouns.Count)] + "ing";
		string possessive = listOfPossessives[Random.Range(0, listOfPossessives.Count)];
		string adjective2 = listOfAdjectives[Random.Range(0, listOfAdjectives.Count)];
		string noun2 = listOfNouns[Random.Range(0, listOfNouns.Count)];
		string preposition = listOfPrepositions [Random.Range (0,listOfPrepositions.Count)];
		string sentence = string.Format("{0} the {1} {2}, {3} {4} {5} {6} {7}.", verb, adjective, noun, preposition,transitiveVerb,possessive, adjective2, noun2 );
		answer = sentence;
		//hintText.text = sentence;
		Debug.Log (sentence);
		gameMgr.turnsOfPhrase.Add ( sentence);
	}
	//public void 

}
