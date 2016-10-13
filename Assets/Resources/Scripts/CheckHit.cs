using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class CheckHit : MonoBehaviour {

	public float  hitChar, massaAtomicaFloat;
	public GameObject character, enemy, balaoFala, enemy1, enemy2, enemy3, controladorBotoes, controladorBotoes2, controladorBotoesPai;
	public GameObject botaoAtacar;
	public static float hitEnemy;
	public static int statusEnemy;
	public Image elementoInimigo, imagem2;
	public Text ataqueEscolhido, defesaInimigo;
	public int numeroAtomicoInt;
	public static bool Atacou;


	// Use this for initialization
	void Start () {
		CheckHit.statusEnemy = 0;
	}
	
	// Update is called once per frame
	void Update () {

	}

	public void converterChar(Text valorChar){
		hitChar = float.Parse(valorChar.text);
	}
	/*public void converterEnemy(Text valorInimigo){
		CheckHit.hitEnemy = float.Parse(valorInimigo.text);
	}*/

	public void checarHit(){
		Invoke ("executarAcoes", 1.5f);

		botaoAtacar.SetActive (false);
	}
	void executarAcoes(){
		Debug.Log ("O valor de hitChar é: " + hitChar);
		Debug.Log ("O valor de hitEnemy é: " + CheckHit.hitEnemy);

		if(hitChar < CheckHit.hitEnemy){
			Debug.Log ("o cara te matou");
			Invoke ("executarAnimacaoContra", 1);
			Invoke ("mudarImagemEnemy", 5);
		}
		if(hitChar > CheckHit.hitEnemy && CheckHit.statusEnemy == 2){
			Invoke ("executarAnimacao3", 3);
			Invoke ("mudarImagemEnemy", 5);
		}
		if(hitChar > CheckHit.hitEnemy && CheckHit.statusEnemy == 1){
			Invoke ("executarAnimacao2", 3);
			Invoke ("mudarImagemEnemy", 5);
		}
		if(hitChar > CheckHit.hitEnemy && CheckHit.statusEnemy == 0){
			Invoke ("mudarImagemEnemy", 5);
			Invoke ("executarAnimacao", 3);
		}
	}

	void executarAnimacao(){
		CheckHit.statusEnemy = 1;
		character.GetComponent<Animator>().Play ("AtaqueChar");
		balaoFala.SetActive (false);
		enemy1.SetActive (false);
	}
	void executarAnimacao2(){
		CheckHit.statusEnemy = 2;
		character.GetComponent<Animator>().Play ("AtaqueChar");
		balaoFala.SetActive (false);
		enemy2.SetActive (false);
	}
	void executarAnimacao3(){
		character.GetComponent<Animator>().Play ("AtaqueChar");
		balaoFala.SetActive (false);
		enemy3.SetActive (false);
		controladorBotoes.SetActive (false);
		Invoke ("matarOterceiro", 2);

	}
	void executarAnimacaoContra(){
		character.GetComponent<Animator>().Play ("AtaqueEnemy");
		//balaoFala.SetActive (false);
		//enemy1.SetActive (false);
	}

	void matarOterceiro(){
		enemy.SetActive (false);
	}

	void mudarImagemEnemy(){
		if (CheckHit.statusEnemy == 1) {
			elementoInimigo.sprite = Resources.Load<Sprite> ("Sprites/" + PlayerPrefs.GetString ("Oponente2"))as Sprite;
			ataqueEscolhido.text = "0";
			defesaInimigo.text = "0";
			if (Oponente.oponenteSegundo == 1) {
				Oponente.ataqueDefesa = 1;
			}
			if (Oponente.oponenteSegundo == 2) {
				Oponente.ataqueDefesa = 2;
			}
			if (Oponente.oponenteSegundo == 3) {
				Oponente.ataqueDefesa = 3;
			}
		}
			if (CheckHit.statusEnemy == 2) {
				elementoInimigo.sprite = Resources.Load<Sprite> ("Sprites/" + PlayerPrefs.GetString ("Oponente3"))as Sprite;
				ataqueEscolhido.text = "0";
				defesaInimigo.text = "0";
				if (Oponente.oponenteTerceiro == 1) {
					Oponente.ataqueDefesa = 1;
				}
				if (Oponente.oponenteTerceiro == 2) {
					Oponente.ataqueDefesa = 2;
				}
				if (Oponente.oponenteTerceiro == 3) {
					Oponente.ataqueDefesa = 3;
				}
		}
		if (CheckHit.Atacou == true) {
			controladorBotoesPai.SetActive(true);
			controladorBotoes2.SetActive (true);
			controladorBotoes.SetActive (true);
			botaoAtacar.SetActive (true);
		}
		if (CheckHit.Atacou == false) {
			Invoke ("ataqueInimigo", 3);
		}
	}

	void ataqueInimigo(){
		int rand;
		rand = Random.Range(0,2);

		if(rand >= 0 && CheckHit.Atacou == false){
			if(Oponente.ataqueDefesa == 1){
				massaAtomicaFloat = 15.9f;
				defesaInimigo.text = ((massaAtomicaFloat).ToString());
			}
			if(Oponente.ataqueDefesa == 2){
				massaAtomicaFloat = 65.4f;
				defesaInimigo.text = ((massaAtomicaFloat).ToString());
			}
			if(Oponente.ataqueDefesa == 3){
				massaAtomicaFloat = 79.9f;
				defesaInimigo.text = ((massaAtomicaFloat).ToString());
			}
			controladorBotoesPai.SetActive(true);
			controladorBotoes2.SetActive (false);
			controladorBotoes.SetActive (true);
			botaoAtacar.SetActive (true);
		}
		if(rand <= 2 && rand >=1){
			if(Oponente.ataqueDefesa == 1  && CheckHit.Atacou == false){
				numeroAtomicoInt = 8;
				defesaInimigo.text = ((numeroAtomicoInt).ToString());
			}
			if(Oponente.ataqueDefesa == 2){
				numeroAtomicoInt = 30;
				defesaInimigo.text = ((numeroAtomicoInt).ToString());
			}
			if(Oponente.ataqueDefesa == 3){
				numeroAtomicoInt = 35;
				defesaInimigo.text = ((numeroAtomicoInt).ToString());
			}
			controladorBotoesPai.SetActive(true);
			controladorBotoes.SetActive (false);
			controladorBotoes2.SetActive (true);
			botaoAtacar.SetActive (true);
		}
	CheckHit.Atacou = true;
	}
}
