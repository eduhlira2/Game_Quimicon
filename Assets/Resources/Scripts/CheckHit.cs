using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class CheckHit : MonoBehaviour {

	public float hitEnemy, hitChar, massaAtomicaFloat;
	public GameObject character, balaoFala, enemy1, controladorBotoes, controladorBotoes2, controladorBotoesPai;
	public static int statusEnemy;
	public Image elementoInimigo, imagem2;
	public Text ataqueEscolhido, defesaInimigo;
	public int numeroAtomicoInt; 


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
			Invoke ("mudarImagemEnemy", 5);
		}
	}

	void executarAnimacao(){
		CheckHit.statusEnemy = 1;
		character.GetComponent<Animator>().Play ("AtaqueChar");
		balaoFala.SetActive (false);
		enemy1.SetActive (false);
	}

	void mudarImagemEnemy(){
		if (CheckHit.statusEnemy == 1) {
			elementoInimigo.sprite =  Resources.Load<Sprite>("Sprites/"+PlayerPrefs.GetString("Oponente2"))as Sprite;
			ataqueEscolhido.text = "0";
			defesaInimigo.text = "0";
			if(Oponente.oponenteSegundo == 1){
				Oponente.ataqueDefesa = 1;
			}if(Oponente.oponenteSegundo == 2){
				Oponente.ataqueDefesa = 2;
			}if(Oponente.oponenteSegundo == 3){
				Oponente.ataqueDefesa = 3;
			}
			Invoke ("ataqueInimigo", 3);
		}
	}

	void ataqueInimigo(){
		Debug.Log("O opnente escolhido eh o:"+Oponente.ataqueDefesa);
		int rand;
		rand = Random.Range(0,2);
		Debug.Log("O ataque escolhido foi"+rand);

		if(rand >= 0){
			if(Oponente.ataqueDefesa == 1){
				massaAtomicaFloat = 15.9f;
				defesaInimigo.text = ((massaAtomicaFloat).ToString());
				Debug.Log ("O oxigenio esta atacando");
   		}
			if(Oponente.ataqueDefesa == 2){
				massaAtomicaFloat = 65.4f;
				defesaInimigo.text = ((massaAtomicaFloat).ToString());
				Debug.Log ("O zinco esta atacando");

			}
			if(Oponente.ataqueDefesa == 3){
				massaAtomicaFloat = 79.9f;
				defesaInimigo.text = ((massaAtomicaFloat).ToString());
				Debug.Log ("O bromo esta atacando");
			
			}
			controladorBotoesPai.SetActive(true);
			controladorBotoes2.SetActive (false);
			controladorBotoes.SetActive (true);
		}
		if(rand <= 2 && rand >=1){
			if(Oponente.ataqueDefesa == 1){
				numeroAtomicoInt = 8;
				defesaInimigo.text = ((numeroAtomicoInt).ToString());
				Debug.Log ("O oxigenio esta atacando");

			}
			if(Oponente.ataqueDefesa == 2){
				numeroAtomicoInt = 30;
				defesaInimigo.text = ((numeroAtomicoInt).ToString());
				Debug.Log ("O zinco esta atacando");
			}
			if(Oponente.ataqueDefesa == 3){
				numeroAtomicoInt = 35;
				defesaInimigo.text = ((numeroAtomicoInt).ToString());
				Debug.Log ("O bromo esta atacando");
			
			}
			controladorBotoesPai.SetActive(true);
			controladorBotoes.SetActive (false);
			controladorBotoes2.SetActive (true);

		}




	}
}
