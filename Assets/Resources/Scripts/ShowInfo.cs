using UnityEngine;
using System.Collections;

public class ShowInfo : MonoBehaviour {



	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void ShowInformacao(GameObject infoBox){
		infoBox.SetActive(true);
	}
	public void CloswInformacao(GameObject infoBox){
		infoBox.SetActive(false);
	}
}
