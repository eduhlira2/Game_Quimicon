using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class CheckHit : MonoBehaviour {

	public float hitEnemy, hitChar;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void converterChar(Text valorChar){
		hitChar = float.Parse(valorChar.text);
	}
	public void converterEnemy(Text valorInimigo){
		hitEnemy = float.Parse(valorInimigo.text);
	}
	public void checarHit(){
		if(hitChar > hitEnemy){
		}
	}
}
