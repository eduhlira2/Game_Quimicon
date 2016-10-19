using UnityEngine;
using System.Collections;

public class PauseTime : MonoBehaviour {

	public GameObject  tutoAnim;
	private int passouTuto; 

	// Use this for initialization
	void Start () {
		PlayerPrefs.SetInt ("concluirTutorial", 0);
		tutoAnim.SetActive (true);
		Debug.Log ("O valor do Tuto eh: " + PlayerPrefs.GetInt ("concluirTutorial"));
		passouTuto = 0;
		if (PlayerPrefs.GetInt ("concluirTutorial") == 0) {
			ParaTempo ();
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
	}
	void tutoSelecaodeChar(){
		tutoAnim.SetActive (true);
		Time.timeScale = 0.0f;
		tutoAnim.GetComponent<Animator>().Play ("tutoSelecao");
		passouTuto = 1;
	}

}
