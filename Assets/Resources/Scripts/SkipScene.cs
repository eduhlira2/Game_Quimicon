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
	public void changeScene(string cena){
		scene = cena;
		Invoke("passarScene", 1);

	}
	public void ativar_Fade(GameObject fade){
		fade.SetActive(true);
		fade.GetComponent<Animator>().Play ("Fade_In");
	}

	void passarScene(){
		
		SceneManager.LoadScene(scene);
	}

}
