using System;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class DeckController : MonoBehaviour {

	public int card_count;

	private List<string> cards = new List<string>();
	private List<string> card_options = new List<string>();


	// Use this for initialization
	void Start () {
		PopulateDeck ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public string DrawCard() {
		string card = cards [0];
		cards.RemoveAt (0);
		Console.Write (cards.Count.ToString());
		return card;
	}

	public int DeckCount() {
		return cards.Count;
	}

	void PopulateDeck() {
		/* Add card option possibilities to card_options list */ 
		card_options.Add ("G");
		card_options.Add ("M");
		card_options.Add ("T");


		int i = 0; 
		while (i < card_count) {
			cards.Add (card_options [i % 3]);
			i++;
		}

		for (int r = 0; r < cards.Count; r++) {
			string temp = cards[r];
			int randomIndex = UnityEngine.Random.Range(r, cards.Count);
			cards[r] = cards[randomIndex];
			cards[randomIndex] = temp;
		}
	}



}
