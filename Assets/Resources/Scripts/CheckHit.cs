using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class CheckHit : MonoBehaviour {

	public float hitEnemy, hitChar;
	public GameObject character, balaoFala, enemy1;
	public static int statusEnemy;
	public Image elementoInimigo, imagem2;


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
			Debug.Log ("matou o cara");
			Invoke ("executarAnimacao", 3);
			Invoke ("mudarImagemEnemy", 4);
		}
	}

	void executarAnimacao(){
		CheckHit.statusEnemy = 1;
		character.GetComponent<Animator> ().Play ("AtaqueChar");
		balaoFala.SetActive (false);
		enemy1.SetActive (false);
	}

	void mudarImagemEnemy(){
		if (CheckHit.statusEnemy == 1) {
			elementoInimigo.sprite =  Resources.Load<Sprite> ("Sprites/"+PlayerPrefs.GetString("Oponente2"))as Sprite;

			//fighter3.sprite = Resources.Load<Sprite> ("Sprites/"+nameImage)as Sprite;
		}
	}


}
