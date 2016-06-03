using UnityEngine;
using System.Collections;

public class CardController : MonoBehaviour {

	public GameObject deck_object;

	private DeckController deck;

	private string card_value;
	private Renderer card_renderer;

	// Use this for initialization
	void Start () {
		deck = deck_object.GetComponent<DeckController> ();
		card_renderer = gameObject.GetComponent<Renderer> ();

	}
	
	// Update is called once per frame
	void Update () {
		if (card_value == null) {
			card_value = deck.DrawCard ();

			switch (card_value) {
			case "G":
				card_renderer.material.color = Color.green;
				break;
			case "M":
				card_renderer.material.color = Color.gray;
				break;
			case "T":
				card_renderer.material.color = Color.black;
				break;
			}
		}
	}
}
