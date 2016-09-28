using UnityEngine;
using System.Collections;

public class TabelaPeriodica : MonoBehaviour {


	public GameObject BromoEle;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if (PlayerPrefs.GetInt("Bromo") == 1){
			BromoEle.SetActive(true);
		}
		
	
	}
}
