﻿using UnityEngine;
using System.Collections;

public class PauseTime : MonoBehaviour {

	public GameObject  tutoAnim, MaoTuto;
	private int passouTuto; 

	// Use this for initialization
	void Start () {
		PlayerPrefs.SetInt ("concluirTutorial", 1);

		Debug.Log ("O valor do Tuto eh: " + PlayerPrefs.GetInt ("concluirTutorial"));
		//passouTuto = 0;
		if (PlayerPrefs.GetInt ("concluirTutorial") == 0) {
			tutoAnim.SetActive (true);
			ParaTempo();
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void ParaTempo(){
		Time.timeScale = 0.0f;
		tutoAnim.GetComponent<Animator>().Play ("tutorial_1");
	}
	public void voltarTime(){
		Time.timeScale = 1.0f;
		tutoAnim.SetActive (false);
		if (passouTuto == 0) {
			Invoke ("tutoSelecaodeChar", 3);
		}
		if (passouTuto == 1) {
			MaoTuto.SetActive(true);
		}
	}
	void tutoSelecaodeChar(){
		tutoAnim.SetActive (true);
		Time.timeScale = 0.0f;
		tutoAnim.GetComponent<Animator>().Play ("tutoSelecao");
		passouTuto = 1;

	}

}
