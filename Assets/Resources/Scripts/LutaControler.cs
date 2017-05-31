using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LutaControler : MonoBehaviour {

	public GameObject AtacarButton, suaVezAnimation, botaoAtacar, controladorBotoes, atackAnimation;
	public GameObject enemy1, enemy2, enemy3, imagemInimigo, imagemJogador,player3,player2,player1, teste;
	private int myTurn, ataqueEnemy, natomicoEnemy, ataqueSelecionado, contadorEnemy, contadorPlayer, mortesEnemy, mortesPlayer;
	private float massatomicaEnemy;
	public Text ataqueEscolhido,defesaInimigo;
	public Image imagemEnemy, imagemPlayer;


	// Use this for initialization
	void Start () {
		AtacarButton.SetActive(false);
		myTurn = 1;
		controladorVez();
		contadorEnemy = 1;
		contadorPlayer = 1;
	}
	
	// Update is called once per frame
	void Update () {
			
	}

	void controladorVez(){
		
		if(myTurn == 1){
			suaVezAnimation.GetComponent<Animator> ().Play ("Sua_Vez");
			controladorBotoes.SetActive(true);
			myTurn = 2;
		}else{
			suaVezAnimation.GetComponent<Animator> ().Play ("vez)Oponente");
			myTurn = 1;
			Invoke("vezOponente", 2);
		}
	} 

	public void selecionarValor(string ataque){
		if(ataque == "massaatomica"){
			ataqueEscolhido.text = ((ValoresElementos.massaAtomicaFloat).ToString());
			botaoAtacar.SetActive(true);
			ataqueSelecionado = 1;
		}else{
			ataqueEscolhido.text = ((ValoresElementos.numeroAtomicoInt).ToString());
			botaoAtacar.SetActive(true);
			ataqueSelecionado = 2;
		}
	}

	public void Atacar(){

		if(ataqueSelecionado == 2){
			if(PlayerPrefs.GetString("Oponente"+contadorEnemy.ToString()) == "Oxigenio"){
				natomicoEnemy = 8;
				defesaInimigo.text = ((natomicoEnemy).ToString());
			}
			if(PlayerPrefs.GetString("Oponente"+contadorEnemy.ToString()) == "Bromo"){
				natomicoEnemy = 35;
				defesaInimigo.text = ((natomicoEnemy).ToString());
			}
			if(PlayerPrefs.GetString("Oponente"+contadorEnemy.ToString()) == "Zinco"){
				natomicoEnemy = 30;
				defesaInimigo.text = ((natomicoEnemy).ToString());
			}
			if(PlayerPrefs.GetString("Oponente"+contadorEnemy.ToString()) == "Boro"){
				natomicoEnemy = 5;
				defesaInimigo.text = ((natomicoEnemy).ToString());
			}
		}else{
			if(PlayerPrefs.GetString("Oponente"+contadorEnemy.ToString()) == "Oxigenio"){
				massatomicaEnemy = 15.9f;
				defesaInimigo.text = ((massatomicaEnemy).ToString());
			}
			if(PlayerPrefs.GetString("Oponente"+contadorEnemy.ToString()) == "Bromo"){
				massatomicaEnemy = 79.9f;
				defesaInimigo.text = ((massatomicaEnemy).ToString());
			}
			if(PlayerPrefs.GetString("Oponente"+contadorEnemy.ToString()) == "Zinco"){
				massatomicaEnemy = 65.4f;
				defesaInimigo.text = ((massatomicaEnemy).ToString());
			}
			if(PlayerPrefs.GetString("Oponente"+contadorEnemy.ToString()) == "Boro"){
				massatomicaEnemy = 10.8f;
				defesaInimigo.text = ((massatomicaEnemy).ToString());
			}
		}
		controladorBotoes.SetActive(false);
		checkHit();
	}

	void checkHit(){

		if( ataqueSelecionado == 2){
			if(float.Parse(ataqueEscolhido.text)> natomicoEnemy){
				Invoke("animGanho", 1);
				//"O oponente Perdeu"
			}else{
				Invoke("animPerda", 1);
				//"O oponente Venceu"
			}
		}else{
			if(float.Parse(ataqueEscolhido.text)> massatomicaEnemy){
				Invoke("animGanho", 1);
				//"O oponente Perdeu"
			}else{
				Invoke("animPerda", 1);
				//"O oponente Venceu"
			}
		}
	}

	void animGanho(){
		atackAnimation.GetComponent<Animator> ().Play ("AtaqueChar");
		mortesEnemy++;
		if(contadorEnemy == 1){
			enemy1.SetActive(false);
		}if(contadorEnemy == 2){
			enemy2.SetActive(false);
		}if(contadorEnemy == 3){
			enemy3.SetActive(false);
		}
		ataqueEscolhido.text = "0";
		defesaInimigo.text = "0";
		contadorEnemy++;
		Invoke("mudarChars", 2);

	}
	void animPerda(){
		atackAnimation.GetComponent<Animator> ().Play ("AtaqueEnemy");
		mortesPlayer++;
		if(contadorPlayer == 1){
			GameObject.Find(teste.GetComponent<Image>().sprite.name).SetActive(false);
		}if(contadorPlayer == 2){
			GameObject.Find(teste.GetComponent<Image>().sprite.name).SetActive(false);
		}if(contadorPlayer== 3){
			GameObject.Find(teste.GetComponent<Image>().sprite.name).SetActive(false);
		}
		ataqueEscolhido.text = "0";
		defesaInimigo.text = "0";
		contadorPlayer++;
		Invoke("mudarChars", 2);
	}

	void mudarChars(){
		if(contadorEnemy == 2){
			imagemEnemy.sprite = Resources.Load<Sprite> ("Sprites/"+ PlayerPrefs.GetString("Oponente"+contadorEnemy.ToString()))as Sprite;
		}
		if(contadorEnemy == 3){
			imagemEnemy.sprite = Resources.Load<Sprite> ("Sprites/"+ PlayerPrefs.GetString("Oponente"+contadorEnemy.ToString()))as Sprite;
		}
		if(contadorEnemy == 4){
			imagemInimigo.SetActive(false);
		}
		// nessa parte muda a imagem do jogador
		if(contadorPlayer == 2){
			imagemPlayer.sprite = Resources.Load<Sprite> ("Sprites/"+ PlayerPrefs.GetString("Lutador"+contadorPlayer.ToString()))as Sprite;
		}
		if(contadorPlayer == 3){
			imagemPlayer.sprite = Resources.Load<Sprite> ("Sprites/"+ PlayerPrefs.GetString("Lutador"+contadorPlayer.ToString()))as Sprite;
		}
		if(contadorPlayer == 4){
			imagemJogador.SetActive(false);
		}
		controladorVez();
	}

	void vezOponente(){
		controladorBotoes.SetActive(false);
		ataqueEnemy = Random.Range(0,2);

		if(ataqueEnemy == 0){
			if(PlayerPrefs.GetString("Oponente"+contadorEnemy.ToString()) == "Oxigenio"){
				natomicoEnemy = 8;
				defesaInimigo.text = ((natomicoEnemy).ToString());
			}
			if(PlayerPrefs.GetString("Oponente"+contadorEnemy.ToString()) == "Bromo"){
				natomicoEnemy = 35;
				defesaInimigo.text = ((natomicoEnemy).ToString());
			}
			if(PlayerPrefs.GetString("Oponente"+contadorEnemy.ToString()) == "Zinco"){
				natomicoEnemy = 30;
				defesaInimigo.text = ((natomicoEnemy).ToString());
			}
			if(PlayerPrefs.GetString("Oponente"+contadorEnemy.ToString()) == "Boro"){
				natomicoEnemy = 5;
				defesaInimigo.text = ((natomicoEnemy).ToString());
			}
		}
		if(ataqueEnemy == 1){
			if(PlayerPrefs.GetString("Oponente"+contadorEnemy.ToString()) == "Oxigenio"){
				massatomicaEnemy = 15.9f;
				defesaInimigo.text = ((massatomicaEnemy).ToString());
			}
			if(PlayerPrefs.GetString("Oponente"+contadorEnemy.ToString()) == "Bromo"){
				massatomicaEnemy = 79.9f;
				defesaInimigo.text = ((massatomicaEnemy).ToString());
			}
			if(PlayerPrefs.GetString("Oponente"+contadorEnemy.ToString()) == "Zinco"){
				massatomicaEnemy = 65.4f;
				defesaInimigo.text = ((massatomicaEnemy).ToString());
			}
			if(PlayerPrefs.GetString("Oponente"+contadorEnemy.ToString()) == "Boro"){
				massatomicaEnemy = 10.8f;
				defesaInimigo.text = ((massatomicaEnemy).ToString());
			}
		}

	}
}
