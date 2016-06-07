using UnityEngine;
using System.Collections;

public class CardController : MonoBehaviour {

	public GameObject deck_object;
    public Material[] materials;

    private DeckController deck;

    public string card_value;
	private Renderer card_renderer;

	// Use this for initialization
	void Start () {
		deck = deck_object.GetComponent<DeckController> ();
		card_renderer = gameObject.GetComponent<Renderer> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (card_value == "") {
			card_value = deck.DrawCard ();

			switch (card_value) {
			case "G":
				card_renderer.material = materials[0];
				break;
			case "M":
                card_renderer.material = materials[1];
                break;
			case "T":
                card_renderer.material = materials[2];
                break;
			}
		}
	}

}
