using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuestInfo : MonoBehaviour
{
	public string questName;
	public LocationObjective[] objectives;
	public Location[] assignedLocations;
	public bool questRunning;
	public bool readyNext;
	public int x;
	public Text questText;
	public Text objectiveText;

	void Start ()
	{
		x = 0;
		questRunning = false;
		readyNext = false; 
		StartQuest ();

	}

	void StartQuest ()
	{	
		print ("Quest Started");
		questText.text = questName + " quest started!";
		Instantiate (objectives [x]);
		objectives [x].objectiveLocation = assignedLocations [0];
		objectives [x].quest = this;
	
	}

	public void RunQuest ()
	{
		if (x >= objectives.Length && readyNext == true) {
			print ("Quest is Over");
			questText.text = questName + " quest completed!";
			objectiveText.text = "";
			Destroy (this);
		
		}

		else if (readyNext == true) {
			print ("Running Quest");
			questText.text = questName + " quest is running!";
			Instantiate (objectives[x]);
			objectives [x].objectiveLocation = assignedLocations [x];
			objectives [x].quest = this;
			readyNext = false;

		}

	}

	void Update ()
	{
		 
	}

}