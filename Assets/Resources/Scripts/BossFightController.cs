using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BossFightController : MonoBehaviour {

	public GameObject perguntaBoss, AnimController, player1,player2,player3, imagePlayer, imagePlayer2, imagePlayer3;
	public string bossFase;
	public Text pergunta, alternativa1, alternativa2, alternativa3;
	private int atualPergunta = 1, playersVivos =3, errou =1, contadorAcertos;

	// Use this for initialization
	void Start () {
		AnimController.GetComponent<Animator> ().Play ("Intro_Boss");
		Invoke("ativarPergunta", 3);
	}
	
	// Update is called once per frame
	void Update () {
		if (contadorAcertos == 4) {
			Invoke ("AnimVitoria", 1);
			contadorAcertos++;
		}
	}

	void ativarPergunta(){
		//errou = 0;
		//perguntaBoss.SetActive (true);
		if(bossFase == "boss1"){
			if (atualPergunta == 1) {
				pergunta.text = "O Hélio é um elemento do grupo dos:";
				alternativa1.text = "Gases Nobres";
				alternativa2.text = "Não-Metais";
				alternativa3.text = "Metais Alcalinos";
			}if (atualPergunta == 2) {
				pergunta.text = "Qual o Número Atômico do Hélio? ";
				alternativa1.text = "2";
				alternativa2.text = "6";
				alternativa3.text = "5";
			}if (atualPergunta == 3) {
				pergunta.text = "Qual dessas alternativas é uma característica do Hélio?";
				alternativa1.text = "pesado";
				alternativa2.text = "verde e transparente";
				alternativa3.text = "Incolor e Inodoro";
			}if (atualPergunta == 4) {
				pergunta.text = "Qual o símbolo do Hélio de acordo com a Tabela Periódica?";
				alternativa1.text = "H";
				alternativa2.text = "He";
				alternativa3.text = "Hio";
			}if (atualPergunta == 5) {
				pergunta.text = "A Massa Atômica do Hélio é:";
				alternativa1.text = "2";
				alternativa2.text = "3";
				alternativa3.text = "4";
			}if (atualPergunta == 6) {
				pergunta.text = "Qual o ponto de fusão do Hélio em graus Celsius";
				alternativa1.text = "-272,2";
				alternativa2.text = "105,8";
				alternativa3.text = "-24,9";
			}
		}
	}
	void AnimVitoria(){
		AnimController.GetComponent<Animator> ().Play ("VitoriaBoss");
		if ( PlayerPrefs.GetInt("auxHistorico") == PlayerPrefs.GetInt ("contadorTrilha") ) { 
			LutaControler.contadorTrilha++;
			PlayerPrefs.SetInt ("contadorTrilha", PlayerPrefs.GetInt ("contadorTrilha") + LutaControler.contadorTrilha);
		}
	}
	void AnimDerrota(){
		//aqui vai a animação da derrota
		Debug.Log("Aparece Derrota");
	}

	public void alternativaCorreta (Text alternativa){
		
		if (alternativa.text == "Gases Nobres") {
			AnimController.GetComponent<Animator> ().Play ("AtaqueCharBoss");
			atualPergunta++; contadorAcertos++;
			ativarPergunta ();
		} else {
			if (alternativa.text == "2") {
				AnimController.GetComponent<Animator> ().Play ("AtaqueCharBoss");
				atualPergunta++; contadorAcertos++;
				ativarPergunta ();
			} else {
				if (alternativa.text == "Incolor e Inodoro") {
					AnimController.GetComponent<Animator> ().Play ("AtaqueCharBoss");
					atualPergunta++; contadorAcertos++;
					ativarPergunta ();
				} else {
					if (alternativa.text == "He") {
						AnimController.GetComponent<Animator> ().Play ("AtaqueCharBoss");
						atualPergunta++; contadorAcertos++;
						ativarPergunta ();
					} else {
						if (alternativa.text == "4") {
							AnimController.GetComponent<Animator> ().Play ("AtaqueCharBoss");
							atualPergunta++; contadorAcertos++;
							ativarPergunta ();
						} else {
							if (alternativa.text == "-272,2") {
								AnimController.GetComponent<Animator> ().Play ("AtaqueCharBoss");
								atualPergunta++; contadorAcertos++;
								ativarPergunta ();
							} else {
								if (alternativa.text == "gfgfgfgff") {
									AnimController.GetComponent<Animator> ().Play ("AtaqueCharBoss");
									atualPergunta++; contadorAcertos++;
									ativarPergunta ();
								} else {
									if (alternativa.text == "rsdsds7") {
										AnimController.GetComponent<Animator> ().Play ("AtaqueCharBoss");
										atualPergunta++; contadorAcertos++;
										ativarPergunta (); 
									} else {
										if (alternativa.text == "redfdfdf9") {
											AnimController.GetComponent<Animator> ().Play ("AtaqueCharBoss");
											atualPergunta++; contadorAcertos++;
											ativarPergunta ();
										} else {
											if (alternativa.text == "refdfdfd0") {
												AnimController.GetComponent<Animator> ().Play ("AtaqueCharBoss");
												atualPergunta++; contadorAcertos++;
												ativarPergunta ();
											} else {
												if (alternativa.text == "respasds1") {
													AnimController.GetComponent<Animator> ().Play ("AtaqueCharBoss");
													atualPergunta++; contadorAcertos++;
													ativarPergunta ();
												} else {
													if (alternativa.text == "respostsdsda12") {
														AnimController.GetComponent<Animator> ().Play ("AtaqueCharBoss");
														atualPergunta++; contadorAcertos++;
														ativarPergunta ();
													} else {
														if (alternativa.text == "resposta1sas3") {
															AnimController.GetComponent<Animator> ().Play ("AtaqueCharBoss");
															atualPergunta++; contadorAcertos++;
															ativarPergunta ();
														}else {
															errou = 1;
															Errou ();
														} 
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
			}
		}


	}

	void SumirPlayer(){
		if (playersVivos == 3) {
			player1.SetActive(false);
			GameObject.Find(imagePlayer.GetComponent<Image>().sprite.name).SetActive(false);
		}if (playersVivos == 2) {
			player2.SetActive(false);
			GameObject.Find(imagePlayer2.GetComponent<Image>().sprite.name).SetActive(false);
		}if (playersVivos == 1) {
			player3.SetActive(false);
			GameObject.Find(imagePlayer3.GetComponent<Image>().sprite.name).SetActive(false);
		}
		playersVivos--;
		atualPergunta++;
		ativarPergunta ();

	}
	void Errou (){
		if (playersVivos == 3 && errou==1) {
			AnimController.GetComponent<Animator> ().Play ("AtaqueBoss");
			Invoke ("SumirPlayer", 1.6f);
		}if (playersVivos == 2 && errou==1) {
			AnimController.GetComponent<Animator> ().Play ("AtaqueBoss2");
			Invoke ("SumirPlayer", 1.6f);
		}if (playersVivos == 1 && errou==1) {
			AnimController.GetComponent<Animator> ().Play ("AtaqueBoss3");
			Invoke ("SumirPlayer", 1.6f);
			Invoke ("AnimDerrota", 3);
		}

	}
}
