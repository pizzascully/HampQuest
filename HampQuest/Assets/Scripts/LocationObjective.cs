using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LocationObjective : MonoBehaviour {

	public string objectiveName;
	public Location objectiveLocation;
	public bool locationFound;
	public QuestInfo quest;
	public Location location;
	public int x;

	void Start () {
		x = quest.x;
		location = quest.assignedLocations [x];
		locationFound = false;
		objectiveName = "Find the " + location.locationName;
		quest.objectiveText.text = objectiveName;


	}
		
	void FindIt(){  
		if (objectiveLocation.locationFound == true) {
			print ("location found"); 
			quest.questText.text = location.locationName + " found!";
			locationFound = true;
			quest.readyNext = true;
			print ("this objective is about to be destroyed");
			if (quest.questRunning == false) {
				quest.x += 1;
				quest.GetComponent<QuestInfo> ().RunQuest ();
				print ("quest will run");
			}
			Destroy (this);
		}
		
	}

	void Update () {
		FindIt ();
	}
}
