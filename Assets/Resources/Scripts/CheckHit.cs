using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class CheckHit : MonoBehaviour {

	public float  hitChar, massaAtomicaFloat;
	public GameObject character, enemy, balaoFala, enemy1, enemy2, enemy3, controladorBotoes, controladorBotoes2, controladorBotoesPai;
	public GameObject botaoAtacar, oxigenio, bromo, zinco, TurnAnimation, valorEnemy, ValorPlayer;
	public GameObject recipiente1, recipiente2, recipiente3, tutoAnim, controladorSuaVez;
	public static float hitEnemy;
	public static int statusEnemy, empate, empates, comensaldaMorte, comensaldaMorte2;
	public Image elementoInimigo, imagem2;
	public Text ataqueEscolhido, defesaInimigo;
	public int numeroAtomicoInt, i;
	private int personagemNafila, atacouMA, atacouNM;
	public static bool Atacou, personagem1Morto;
	public Image jogador;	
	public bool ultimoEnemy;


	// Use this for initialization
	void Start () {
		i = 0;
		personagem1Morto = false;
		CheckHit.statusEnemy = 0;
		personagemNafila = 0;
		empates = 0;
		InBattle.contadorminhaVez = 1;

	}
	
	// Update is called once per frame
	void Update () {

		/* isso aqui nao esta certo, isso eh um erro
		if( InBattle.contadorminhaVez == 3){
			TurnAnimation.GetComponent<Animator>().Play ("Sua_Vez");
		}*/

		if(CheckHit.comensaldaMorte == 3){

			enemy3.SetActive(false);
			controladorBotoesPai.SetActive(false);
			controladorBotoes.SetActive(false);
			controladorBotoes2.SetActive(false);
			controladorSuaVez.SetActive(false);
			if (i == 0) {
				Invoke ("AnimWinner", 3.5f);
			}
			Debug.Log("Venceu Porra");
			i = i + 1;
		}
		if(CheckHit.comensaldaMorte2 == 3){
			Debug.Log("Perdeu merda");
		}
		//Esses São os Contra Ataques;

		if(CheckHit.Atacou == true && atacouNM == 1 && ValoresElementos.personagemSelecionado == 2){
			InBattle.contadorminhaVez = InBattle.contadorminhaVez+1;
			controladorBotoesPai.SetActive(true);
			controladorBotoes.SetActive (false);
			controladorBotoes2.SetActive (true);
			botaoAtacar.SetActive (false);
			ValoresElementos.personagemSelecionado = 1;
			atacouNM = 0;

	}
		if(CheckHit.Atacou == true && atacouMA == 1 && ValoresElementos.personagemSelecionado == 2){
			InBattle.contadorminhaVez = InBattle.contadorminhaVez+1;
			controladorBotoesPai.SetActive(true);
			controladorBotoes2.SetActive (false);
			controladorBotoes.SetActive (true);
			botaoAtacar.SetActive (false);
			atacouNM = 0;
			ValoresElementos.personagemSelecionado = 1;
		
		}
	}
	void AnimWinner(){
		character.GetComponent<Animator> ().Play ("Winner");
		ShowElement.eletrons = ShowElement.eletrons+20;
		PlayerPrefs.SetInt("QtdEletrons",ShowElement.eletrons);
	}

	public void converterChar(Text valorChar){
		hitChar = float.Parse(valorChar.text);
	}
	/*public void converterEnemy(Text valorInimigo){
		CheckHit.hitEnemy = float.Parse(valorInimigo.text);
	}*/

	public void checarHit(){

		if(PlayerPrefs.GetInt ("concluirTutorial") == 0){
			Invoke("AnimacaoEnemy", 6.5f);
		}

		Invoke ("executarAcoes", 1.5f);

		botaoAtacar.SetActive (false);
	}

	void AnimacaoEnemy(){
		tutoAnim.SetActive (true);
		Time.timeScale = 0.0f;
		tutoAnim.GetComponent<Animator>().Play ("tutoEnemy");
		PlayerPrefs.SetInt ("concluirTutorial", 1);
	}

	void executarAcoes(){
		Debug.Log ("O valor de hitChar é: " + hitChar);
		Debug.Log ("O valor de hitEnemy é: " + CheckHit.hitEnemy);

		if(hitChar < CheckHit.hitEnemy){
			Debug.Log ("o cara te matou");
			Invoke ("executarAnimacaoContra", 2);
			Invoke ("mudarImagemPlayer", 3);

		}
		if(hitChar == CheckHit.hitEnemy){
			empates = empates+1;
			Invoke ("executarAnimacaoEmpate", 2);
			Invoke("Empate", 5);
				
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
		CheckHit.comensaldaMorte = CheckHit.comensaldaMorte+1;
		CheckHit.statusEnemy = 1;
		character.GetComponent<Animator>().Play ("AtaqueChar");
		balaoFala.SetActive (false);
		enemy1.SetActive (false);
	}
	void executarAnimacao2(){
		CheckHit.comensaldaMorte = CheckHit.comensaldaMorte+1;
		CheckHit.statusEnemy = 2;
		character.GetComponent<Animator>().Play ("AtaqueChar");
		balaoFala.SetActive (false);
		enemy2.SetActive (false);
	}
	void executarAnimacao3(){
		CheckHit.comensaldaMorte = CheckHit.comensaldaMorte+1;
		character.GetComponent<Animator>().Play ("AtaqueChar");
		balaoFala.SetActive (false);
		enemy3.SetActive (false);
		controladorBotoes.SetActive (false);
		Invoke ("matarOterceiro", 2);

	}
	void executarAnimacaoContra(){
		personagemNafila = personagemNafila+1;
		character.GetComponent<Animator>().Play ("AtaqueEnemy");
		balaoFala.SetActive (false);
		//balaoFala.SetActive (false);
		//enemy1.SetActive (false);
	}

	void executarAnimacaoEmpate(){
		character.GetComponent<Animator>().Play ("Empate");
		balaoFala.SetActive (false);
	}

	void matarOterceiro(){
		
		enemy.SetActive (false);
	}

	void Empate(){
		empate = Random.Range(0,2);
		if(empate == 0 && empates == 1){
			if (CheckHit.statusEnemy == 2) {
				Debug.Log("entrou tres empate");
				executarAnimacao3 ();
			}
			if (CheckHit.statusEnemy == 1) {
				Debug.Log("entrou duas empate");
				executarAnimacao2 ();
			}
			if (CheckHit.statusEnemy == 0) {
				Debug.Log("entrou uma empate");
				executarAnimacao ();
			}
			Debug.Log("entrou no 1 empate");
			Invoke("mudarImagemEnemy", 1);
		}
		if(empate == 0 && empates == 2){
			if (CheckHit.statusEnemy == 2) {
				Debug.Log("entrou tres empate");
				executarAnimacao3 ();
			}
			if (CheckHit.statusEnemy == 1) {
				Debug.Log("entrou duas empate");
				executarAnimacao2 ();
			}
			if (CheckHit.statusEnemy == 0) {
				Debug.Log("entrou uma empate");
				executarAnimacao ();
			}
			Debug.Log("entrou no 2 empate");
			Invoke("mudarImagemEnemy", 1);
		}
		if(empate == 0 && empates == 3){
			if (CheckHit.statusEnemy == 2) {
				Debug.Log("entrou tres empate");
				executarAnimacao3 ();
			}
			if (CheckHit.statusEnemy == 1) {
				Debug.Log("entrou duas empate");
				executarAnimacao2 ();
			}
			if (CheckHit.statusEnemy == 0) {
				Debug.Log("entrou uma empate");
				executarAnimacao ();
			}
			Debug.Log("entrou no 3 empate");
			}
		if(empate == 1 && empates == 1 ){
			executarAnimacaoContra();
			Invoke("mudarImagemPlayer", 1);
		}
		if(empate == 1 && empates == 2 ){
			executarAnimacaoContra();
			Invoke("mudarImagemPlayer", 1);
		}
		if(empate == 1 && empates == 3 ){
			executarAnimacaoContra();
			Invoke("mudarImagemPlayer", 1);
		}
	}

	void mudarImagemEnemy(){
		if(InBattle.contadorminhaVez == 2 || InBattle.contadorminhaVez == 3){
			TurnAnimation.GetComponent<Animator>().Play ("Sua_Vez");
		}
		

		if (CheckHit.statusEnemy == 1) {
			CheckHit.Atacou = false;
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
				//CheckHit.Atacou = false;
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
			if (Oponente.oponenteTerceiro == 4) {
				Oponente.ataqueDefesa = 4;
			}

			 //ultimoEnemy = true;
		}
		if (CheckHit.Atacou == true && InBattle.contadorminhaVez == 2) {
			InBattle.contadorminhaVez = InBattle.contadorminhaVez+1;
			controladorBotoesPai.SetActive(true);
			controladorBotoes2.SetActive (true);
			controladorBotoes.SetActive (true);
			botaoAtacar.SetActive (false);
		}
		if (CheckHit.Atacou == false && ultimoEnemy == false) {
			TurnAnimation.GetComponent<Animator>().Play ("vez)Oponente");
			Invoke ("ataqueInimigo", 3);
		}
	}
	void mudarImagemPlayer(){
		CheckHit.comensaldaMorte2 = CheckHit.comensaldaMorte2+1;
		personagem1Morto = true;
		if(CheckHit.Atacou == true){
			TurnAnimation.GetComponent<Animator>().Play ("Sua_Vez");
		}

		Debug.Log("O valor de personagemNafila eh: "+ personagemNafila);
		if(personagemNafila == 5){
			if (PlayerPrefs.GetString ("Lutador1") == "Oxigenio") {
				oxigenio.SetActive (false);
				jogador.sprite =  Resources.Load<Sprite> ("Sprites/Hud/"+"Selecione um elemento")as Sprite;
				recipiente1.SetActive(false);
				ataqueEscolhido.text = "0";
				defesaInimigo.text = "0";

			}
			if (PlayerPrefs.GetString ("Lutador1") == "Zinco") {
				zinco.SetActive (false);
				jogador.sprite =  Resources.Load<Sprite> ("Sprites/Hud/"+"Selecione um elemento")as Sprite;
				recipiente1.SetActive(false);
				ataqueEscolhido.text = "0";
				defesaInimigo.text = "0";

			}
			if (PlayerPrefs.GetString ("Lutador1") == "Bromo") {
				bromo.SetActive (false);
				jogador.sprite =  Resources.Load<Sprite> ("Sprites/Hud/"+"Selecione um elemento")as Sprite;
				recipiente1.SetActive(false);
				ataqueEscolhido.text = "0";
				defesaInimigo.text = "0";
				}
			if (PlayerPrefs.GetString ("Lutador1") == "Bario") {
				bromo.SetActive (false);
				jogador.sprite =  Resources.Load<Sprite> ("Sprites/Hud/"+"Selecione um elemento")as Sprite;
				recipiente1.SetActive(false);
				ataqueEscolhido.text = "0";
				defesaInimigo.text = "0";
			}
			Debug.Log("entrou no personagem3");
		}

		if(personagemNafila == 3){
			if (PlayerPrefs.GetString ("Lutador2") == "Oxigenio") {
				oxigenio.SetActive (false);
				recipiente2.SetActive(false);
				jogador.sprite =  Resources.Load<Sprite> ("Sprites/Hud/"+"Selecione um elemento")as Sprite;
				ataqueEscolhido.text = "0";
				defesaInimigo.text = "0";
				personagemNafila = personagemNafila+1;
			}
			if (PlayerPrefs.GetString ("Lutador2") == "Zinco") {
				zinco.SetActive (false);
				jogador.sprite = Resources.Load<Sprite> ("Sprites/Hud/"+"Selecione um elemento")as Sprite;
				recipiente2.SetActive(false);
				ataqueEscolhido.text = "0";
				defesaInimigo.text = "0";
				personagemNafila = personagemNafila+1;
			}
			if (PlayerPrefs.GetString ("Lutador2") == "Bromo") {
				bromo.SetActive (false);
				jogador.sprite = Resources.Load<Sprite> ("Sprites/Hud/"+"Selecione um elemento")as Sprite;
				recipiente2.SetActive(false);
				ataqueEscolhido.text = "0";
				defesaInimigo.text = "0";
				personagemNafila = personagemNafila+1;
			}
			if (PlayerPrefs.GetString ("Lutador2") == "Bario") {
				bromo.SetActive (false);
				jogador.sprite =  Resources.Load<Sprite> ("Sprites/Hud/"+"Selecione um elemento")as Sprite;
				recipiente1.SetActive(false);
				ataqueEscolhido.text = "0";
				defesaInimigo.text = "0";
			}
			Debug.Log("entrou no personagem2");
		}
		if(personagemNafila == 1){

			if (PlayerPrefs.GetString ("Lutador3") == "Oxigenio") {
				oxigenio.SetActive (false);
				recipiente3.SetActive(false);
				jogador.sprite =  Resources.Load<Sprite> ("Sprites/Hud/"+"Selecione um elemento")as Sprite;
				ataqueEscolhido.text = "0";
				defesaInimigo.text = "0";
				personagemNafila = personagemNafila+1;
			}	
			if (PlayerPrefs.GetString ("Lutador3") == "Zinco") {
				zinco.SetActive (false);
				recipiente3.SetActive(false);
				jogador.sprite =  Resources.Load<Sprite> ("Sprites/Hud/"+"Selecione um elemento")as Sprite;
				ataqueEscolhido.text = "0";
				defesaInimigo.text = "0";
				personagemNafila = personagemNafila+1;
			}
			if (PlayerPrefs.GetString ("Lutador3") == "Bromo") {
				bromo.SetActive (false);
				recipiente3.SetActive(false);
				jogador.sprite =  Resources.Load<Sprite> ("Sprites/Hud/"+"Selecione um elemento")as Sprite;
				ataqueEscolhido.text = "0";
				defesaInimigo.text = "0";
				personagemNafila = personagemNafila+1;
			}
			if (PlayerPrefs.GetString ("Lutador3") == "Bario") {
				bromo.SetActive (false);
				jogador.sprite =  Resources.Load<Sprite> ("Sprites/Hud/"+"Selecione um elemento")as Sprite;
				recipiente1.SetActive(false);
				ataqueEscolhido.text = "0";
				defesaInimigo.text = "0";
			}
			Debug.Log("entrou no personagem1");
		}


		if (CheckHit.Atacou == false) {
			Invoke ("ataqueInimigo", 3);
		}
		if (InBattle.contadorminhaVez == 2) {
			Invoke ("ataqueInimigo", 3);
		}
	}

	void ataqueInimigo(){
		int rand;
		rand = Random.Range(0,2);

		if(rand == 0 && CheckHit.Atacou == false){
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
			if(Oponente.ataqueDefesa == 4){
				massaAtomicaFloat = 10.8f;
				defesaInimigo.text = ((massaAtomicaFloat).ToString());
			}
			atacouMA = 1;
			if(personagem1Morto == false){
				controladorBotoesPai.SetActive(true);
				controladorBotoes.SetActive (true);
				controladorBotoes2.SetActive (false);
				botaoAtacar.SetActive (false);
			}
		}
		if( rand ==1 && CheckHit.Atacou == false){
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
			if(Oponente.ataqueDefesa == 4){
				numeroAtomicoInt = 5;
				defesaInimigo.text = ((numeroAtomicoInt).ToString());
			}
			atacouNM = 1;
			if(personagem1Morto == false){
				controladorBotoesPai.SetActive(true);
				controladorBotoes.SetActive (false);
				controladorBotoes2.SetActive (true);
				botaoAtacar.SetActive (false);

		}
	
	}
		CheckHit.Atacou = true;
  }
}
