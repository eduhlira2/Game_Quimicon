using UnityEngine;
using System.Collections;

public class PauseTime : MonoBehaviour {

	// Use this for initialization
	void Start () {
		ParaTempo();
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void ParaTempo(){
		Time.timeScale = 0.0f;
	}
}
