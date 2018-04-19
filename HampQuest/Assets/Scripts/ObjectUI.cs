
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObjectUI : MonoBehaviour
{

	//info
	public new string name;
	public string description;
	//Interactive
	public bool displayKey;
	public KeyCode giveInformation;
	//UI
	public Text uiElement;
	public float fadeTime;
	public Text infoText;
	public Image infoBox;
	public int ID;
		
	void OnAwake () {
	}

	void Start ()
	{
		infoBox.color = Color.clear;
		uiElement.color = Color.clear;
		giveInformation = KeyCode.E;
		displayKey = false; 

		 

	}

	void Update ()
	{
		if (Input.GetKeyUp (giveInformation) && displayKey == true)
			infoText.text = name + " - " + description;
			infoBox.color = Color.white; 
			
	}

	void OnMouseOver ()
	{
		displayKey = true;
		if (displayKey == true) {
			uiElement.text = "" + giveInformation + "";
			uiElement.color = Color.green;
		}
	}

	void OnMouseExit ()
	{
		displayKey = false;
		if (displayKey == false) {
		uiElement.color = Color.clear;
		}
	}
}
