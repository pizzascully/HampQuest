using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Location : MonoBehaviour {

	public string locationName;
	[SerializeField]
	private GameObject localObject;
	[SerializeField]
	private Image objectMarker;
	[SerializeField]
	private Vector3 markerPosition; 
	[SerializeField]
	private Text keyText; 
	[SerializeField]
	private bool displayKey;
	public KeyCode activateKey;
	public bool locationFound;

	void Start ()
	{
		keyText.color = Color.clear;
		activateKey = KeyCode.E;
		displayKey = false; 
		locationFound = false;



	}

	void Update ()
	{
		if (Input.GetKeyUp (activateKey) && displayKey == true)
			locationFound = true; 

	}

	void OnMouseOver ()
	{
		displayKey = true;
		if (displayKey == true) {
			keyText.text = "" + activateKey + "";
			keyText.color = Color.green;
		}
	}

	void OnMouseExit ()
	{
		displayKey = false;
		if (displayKey == false) {
			keyText.color = Color.clear;
		}
	}
}
