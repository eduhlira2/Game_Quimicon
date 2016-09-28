using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class SkipScene : MonoBehaviour {

	public string scene;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void changeScene(string scene){
		SceneManager.LoadScene(scene);
	}
}
