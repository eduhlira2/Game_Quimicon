using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControllerFases : MonoBehaviour {

	public GameObject[] fases;
	public GameObject BG;
	// Use this for initialization
	void Start () {
		BG.SetActive (true);
		Debug.Log ("O atual valor da fase eh: "+PlayerPrefs.GetInt ("contadorTrilha"));
		//PlayerPrefs.SetInt ("contadorTrilha", 0);
		for (int i = 0; i < 41; i++) {
			if (PlayerPrefs.GetInt ("contadorTrilha") == i) {
				fases[i].GetComponent<Image> ().color = Color.white;
				fases[i].GetComponent<Button> ().enabled = true;
			}
			if (i < PlayerPrefs.GetInt ("contadorTrilha")) {
				fases[i].GetComponent<Image> ().color = Color.white;
				fases[i].GetComponent<Button> ().enabled = true;
			}
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
