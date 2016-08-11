using UnityEngine;
using System.Linq;
using System.Collections;
using TouchScript.Gestures;

public class CardSlot : MonoBehaviour {

	public GameObject card;
	public GameObject mesh;

	void OnEnable() {
		//GetComponent<TapGesture> ().Tapped += TapHandler;
	}

	void OnDisable() {
		//GetComponent<TapGesture> ().Tapped -= TapHandler;
	}

	/*
	public void TapHandler(object sender, System.EventArgs e) {
		if (card != null) {
			validateSET ();
		}
	}
	*/

	public bool compare3(int a, int b, int c) {
		return (new[] { a, b, c }.Distinct ().Count () == 1) || (new[] { a, b, c }.Distinct ().Count () == 3);
	}

	public GameObject dealFromDeck (Deck deck) {
		card = deck.deal (gameObject.transform.position);
		return card;
	}

	public void release() {
		GameObject sideDeck = GameObject.Find ("SideDeck");
		if (sideDeck != null) {
			sideDeck.GetComponent<Deck> ().add (card);
		}
		card = null;
		GameManager.cardsOnTable -= 1;
	}

	public void select() {
		mesh.SetActive (true);
	}

	public void deselect() {
		mesh.SetActive (false);
	}

}
