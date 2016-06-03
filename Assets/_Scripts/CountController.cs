using System;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class CountController : MonoBehaviour {

	public GameObject deck_object;

	private DeckController deck;
	private Text text;

	// Use this for initialization
	void Start () {
		deck = deck_object.GetComponent<DeckController> ();
		text = gameObject.GetComponent<Text> ();
	}
	
	// Update is called once per frame
	void Update () {
		text.text = "Tiles Left: " + deck.DeckCount().ToString ();
	}

}
