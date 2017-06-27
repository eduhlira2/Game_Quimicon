using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PassarIntro : MonoBehaviour {

	public GameObject ControleAnim;
	public int numeroIntro = 0;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void passarAnim(){
		numeroIntro++;
			ControleAnim.GetComponent<Animator> ().Play ("Introduçao_"+numeroIntro);
			
	}
}
