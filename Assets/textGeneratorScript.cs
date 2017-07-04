using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class textGeneratorScript : MonoBehaviour {

	public List<string> listOfVerbs;
	public List<string> listOfAdjectives;
	public List<string> listOfNouns;

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

	}

	public string GenerateText(){
		string verb = listOfVerbs[Random.Range(0, listOfVerbs.Count)];
		string adjective = listOfAdjectives[Random.Range(0, listOfAdjectives.Count)];
		string noun = listOfNouns[Random.Range(0, listOfNouns.Count)];
		string sentence = string.Format("{0} the {1} {2}.", verb, adjective, noun);

		return sentence;
	}

}
