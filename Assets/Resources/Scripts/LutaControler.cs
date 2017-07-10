using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LutaControler : MonoBehaviour {

	public GameObject AtacarButton, suaVezAnimation, botaoAtacar, controladorBotoes, atackAnimation, maozinhas;
	public GameObject enemy1, enemy2, enemy3, imagemInimigo, imagemJogador,player3,player2,player1, teste;
	public GameObject particulaganho, particulaperda;
	private int myTurn, ataqueEnemy, natomicoEnemy, ataqueSelecionado, contadorEnemy, contadorPlayer, mortesEnemy, mortesPlayer;
	private float massatomicaEnemy;
	public static int enemyAtaqueLimite;
	public Text ataqueEscolhido,defesaInimigo, nomeEnemy;
	public Image imagemEnemy, imagemPlayer;

	public static int contadorTrilha;


	// Use this for initialization
	void Start () {
		AtacarButton.SetActive(false);
		myTurn = 1;
		controladorVez();
		contadorEnemy = 1;
		contadorPlayer = 1;
		enemyAtaqueLimite = 2;
	}
	
	// Update is called once per frame
	void Update () {
			
	}

	void controladorVez(){
		
		if(myTurn == 1){
			enemyAtaqueLimite = 2;
			suaVezAnimation.GetComponent<Animator> ().Play ("Sua_Vez");
			myTurn = 2;
			Invoke ("maozinhaSelect", 3);

		}else{
			suaVezAnimation.GetComponent<Animator> ().Play ("vez)Oponente");
			myTurn = 1;
			Invoke("vezOponente", 3);
		}
	} 

	void maozinhaSelect(){
		maozinhas.SetActive (true);
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
		Invoke("checkHit", 1);
	}

	void checkHit(){

		if( ataqueSelecionado == 2){
			if(float.Parse(ataqueEscolhido.text)> natomicoEnemy){
				particulaganho.SetActive (true);
				Invoke("animGanho", 1);
				//"O oponente Perdeu"
			}else{
				particulaperda.SetActive (true);
				Invoke("animPerda", 1);
				//"O oponente Venceu"
			}
		}else{
			if(float.Parse(ataqueEscolhido.text)> massatomicaEnemy){
				particulaganho.SetActive (true);
				Invoke("animGanho", 1);
				//"O oponente Perdeu"
			}else{
				particulaperda.SetActive (true);
				Invoke("animPerda", 1);
				//"O oponente Venceu"
			}
		}
	}
	void animVictory(){
		if ( PlayerPrefs.GetInt("auxHistorico") == PlayerPrefs.GetInt ("contadorTrilha") ) { 
			contadorTrilha++;
			PlayerPrefs.SetInt ("contadorTrilha", PlayerPrefs.GetInt ("contadorTrilha") + contadorTrilha);
		}
		atackAnimation.GetComponent<Animator> ().Play ("Winner");
	}
	void animGanho(){
		particulaperda.SetActive (false);
		particulaganho.SetActive (false);
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
		particulaperda.SetActive (false);
		particulaganho.SetActive (false);
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
		//contadorPlayer++;
		Invoke("mudarPlayer", 2);

	}

	void mudarChars(){
		
		if(contadorEnemy == 2){
			//atackAnimation.GetComponent<Animator> ().Play ("Morteenemy");
			imagemEnemy.sprite = Resources.Load<Sprite> ("Sprites/"+ PlayerPrefs.GetString("Oponente"+contadorEnemy.ToString()))as Sprite;
			nomeEnemy.text = PlayerPrefs.GetString ("Oponente" + contadorEnemy.ToString ());
		}
		if(contadorEnemy == 3){
			//atackAnimation.GetComponent<Animator> ().Play ("Morteenemy");
			imagemEnemy.sprite = Resources.Load<Sprite> ("Sprites/"+ PlayerPrefs.GetString("Oponente"+contadorEnemy.ToString()))as Sprite;
			nomeEnemy.text = PlayerPrefs.GetString ("Oponente" + contadorEnemy.ToString ());
		}
		if(contadorEnemy == 4){
			imagemInimigo.SetActive(false);
			Invoke ("animVictory", 1);
		}
		if (contadorEnemy != 4) {
			controladorVez ();
		}
	}

	void mudarPlayer(){ //Essa função muda o sprite do personagem para "selecione um elemento", após uma derrota!
		
		imagemPlayer.sprite = Resources.Load<Sprite>("Sprites/"+"selecione_elemento")as Sprite;
		controladorVez ();
	}

	void vezOponente(){
		controladorBotoes.SetActive(false);
		ataqueEnemy = Random.Range(0,2);

		if(ataqueEnemy == 0){
			enemyAtaqueLimite = 0; //essa variavel passa para o script ValoresElementos qual ataque o oponente escolheu
			atackAnimation.GetComponent<Animator> ().Play ("valorEnemy");
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
			enemyAtaqueLimite = 1; 
			atackAnimation.GetComponent<Animator> ().Play ("valorEnemy");
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
		maozinhas.SetActive (true);

	}
}
