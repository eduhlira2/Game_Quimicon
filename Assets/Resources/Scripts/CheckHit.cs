using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class CheckHit : MonoBehaviour {

	public float hitEnemy, hitChar;
	public GameObject character, balaoFala, enemy1, controladorBotoes, controladorBotoes2, controladorBotoesPai;
	public static int statusEnemy;
	public Image elementoInimigo, imagem2;
	public Text ataqueEscolhido, defesaInimigo;


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
			Invoke ("ataqueInimigo", 3);
		}
	}

	void ataqueInimigo(){

		int rand;
		rand = Random.Range(0,2);
		Debug.Log(rand);

		if(rand >= 0){
			if(Oponente.ataqueDefesa == 1){
				defesaInimigo.text = ((Oponente.massaAtomicaFloat).ToString());

			}
			if(Oponente.ataqueDefesa == 2){
				defesaInimigo.text = ((Oponente.massaAtomicaFloat).ToString());

			}
			if(Oponente.ataqueDefesa == 3){
				defesaInimigo.text = ((Oponente.massaAtomicaFloat).ToString());
			
			}
			controladorBotoesPai.SetActive(true);
			controladorBotoes2.SetActive (false);
			controladorBotoes.SetActive (true);
		}
		if(rand <= 2 && rand >=1){
			if(Oponente.ataqueDefesa == 1){
				defesaInimigo.text = ((Oponente.numeroAtomicoInt).ToString());

			}
			if(Oponente.ataqueDefesa == 2){
				defesaInimigo.text = ((Oponente.numeroAtomicoInt).ToString());

			}
			if(Oponente.ataqueDefesa == 3){
				defesaInimigo.text = ((Oponente.numeroAtomicoInt).ToString());
			
			}
			controladorBotoesPai.SetActive(true);
			controladorBotoes.SetActive (false);
			controladorBotoes2.SetActive (true);

		}




	}
}
