using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GameManager : MonoBehaviour {

	public GameObject SquareDeck;
	public GameObject BlueDeck;
	public GameObject YellowDeck;
	public GameObject GreenDeck;
	public GameObject GreenCoins;
	public GameObject WhiteCoins;
	public GameObject BlueCoins;
	public GameObject BlackCoins;
	public GameObject RedCoins;
	public GameObject GoldCoins;

	public static float dY = -2.7f;
	public static float dX = 2.38f;
	public static int rows = 3;
	public static int cols = 6;

	public static int cardsOnTable = 0;

	public GameObject[,] slots = new GameObject[rows, cols];

	void Awake() {
		//placeholders!
		for (int i = 0; i < 10; i++) {
			BlueDeck.GetComponent<Deck> ().createCard ();
			YellowDeck.GetComponent<Deck> ().createCard ();
			GreenDeck.GetComponent<Deck> ().createCard ();
			SquareDeck.GetComponent<Deck> ().createCard ();
			GreenCoins.GetComponent<Deck> ().createCard ();
			WhiteCoins.GetComponent<Deck> ().createCard ();
			BlueCoins.GetComponent<Deck> ().createCard ();
			BlackCoins.GetComponent<Deck> ().createCard ();
			RedCoins.GetComponent<Deck> ().createCard ();
			GoldCoins.GetComponent<Deck> ().createCard ();
		}
	}

	public void deal(Deck deck) {
		foreach (Deck slot in deck.slots) {
			if (slot.isEmpty ()) {
				GameObject card = deck.deal (slot.gameObject.transform.position);
				card.GetComponent<Card> ().flip ();
				//card.transform.eulerAngles = new Vector3(0, 180, 0);
				card.transform.SetParent(slot.gameObject.transform);

			}
		}


	}


	public void quit() {
		Application.Quit();
	}


}
