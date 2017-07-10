using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PassarSceneAuto : MonoBehaviour {

	
	public GameObject fade;

	// Use this for initialization
	void Start () {
        waitForTime();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void waitForTime()
    {
        Invoke("passarAuto", 6);
        Invoke("playFade", 5);
    }

	void passarAuto(){
        if (PlayerPrefs.GetString("Boss") == "vazio")
        {
          
            SceneManager.LoadScene("Luta1");
        }
        else {
          
            SceneManager.LoadScene("Boss1");
        }
            
	}
	void playFade(){
		fade.SetActive (true);
	}
}
