using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Pocket : MonoBehaviour {

	public int value = 0;

	public Text text;

	public void add() {
		value += 1;
		text.text = value + "";
	}

	public void subtract() {
		value -= 1;
		if (value < 0) {
			value = 0;
		}
		text.text = value + "";
	}

}
