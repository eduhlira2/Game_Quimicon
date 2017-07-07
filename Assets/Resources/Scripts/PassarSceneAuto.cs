using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PassarSceneAuto : MonoBehaviour {

	public string scene;
	public GameObject fade;

	// Use this for initialization
	void Start () {
		Invoke("passarAuto", 6);
		Invoke ("playFade", 5);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void passarAuto(){
		SceneManager.LoadScene(scene);
	}
	void playFade(){
		fade.SetActive (true);
	}
}
