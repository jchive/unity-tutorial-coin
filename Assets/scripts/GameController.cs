using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour {

	public int funds = 1000;

	public Text fundsText;
	
	private void Start () {
		UpdateText();
	}
	
	private void UpdateText() {
		fundsText.text = "£" + (funds / 100.0).ToString("F2");
	}

	public void SpendFunds() {
		funds -= 10;
	}

	public void AddFunds() {
		funds += 10;
	}
}
