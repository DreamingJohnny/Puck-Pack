using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.VisualScripting;
using UnityEngine.UI;

public class UIHandler : MonoBehaviour {

	void Start() {

	}

	public void StartBuuMan() {
		Debug.Log("BuuMan should start now.");
	}

	public void QuitGame() {
		Debug.Log("The game should quit now.");

		Application.Quit();
	}

}
