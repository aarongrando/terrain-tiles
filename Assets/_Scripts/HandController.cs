using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class HandController : MonoBehaviour
{

    public GameObject selected_card;
    public GameObject game_over_text;

    private GameObject[] cards;

    void Start()
    {
        cards = GameObject.FindGameObjectsWithTag("HandCard");
    }

    void Update()
    {
        bool hand_full = false;
        foreach (GameObject card in cards)
        {
            if (card.GetComponent<CardController>().card_value != null)
            {
                hand_full = true;
                break;
            }
        }

        if (!hand_full)
        {
            game_over_text.SetActive(true);
        }
    }
}
