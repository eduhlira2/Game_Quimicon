using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ShowElement : MonoBehaviour {

	public GameObject elemento, elemento2, ParticulasNascimento, botaoCriar,avisoErro;
	public string K, L, M, N, O, P, Q,aux_string;
	public Text nEletrons;
	public static int eletrons, jacriou;
	public static int Bromo, qtdbromo;

	public GameObject errorMensage;

	// Use this for initialization
	void Start () {
		//PlayerPrefs.SetInt("QtdEletrons", 56);
		// PlayerPrefs.SetInt("QtdEletrons",0);
		eletrons= PlayerPrefs.GetInt("QtdEletrons");
		nEletrons.text = (PlayerPrefs.GetInt("QtdEletrons").ToString());//recebe a quantidade de eletrons armazenados e mostraa;
		Bromo = PlayerPrefs.GetInt("Bromo");
		qtdbromo = PlayerPrefs.GetInt("qtdBromo");
	}
	
	// Update is called once per frame
	void Update () {

		if( Input.GetKeyDown(KeyCode.X)){
			aumentarEletrons();
		}
	}

	public void ShowElements(string newText){
		this.aux_string= newText;
	}
	public void SaveTo(string ToSave){
		if(ToSave == "K"){
			this.K= aux_string;
		}
		if(ToSave == "L"){
			this.L= aux_string;
		}
		if(ToSave == "M"){
			this.M= aux_string;
		}
		if(ToSave == "N"){
			this.N= aux_string;
		}
		if(ToSave == "O"){
			this.O= aux_string;
		}
		if(ToSave == "P"){
			this.P= aux_string;
		}
		if(ToSave == "Q"){
			this.Q= aux_string;
		}
	}
	public void Checkword(){
		jacriou = 0;
		Invoke("MostrarElemento", 2);
		ParticulasNascimento.SetActive(true);
  }
	void aumentarEletrons(){
	
		ShowElement.eletrons = ShowElement.eletrons+1;
		PlayerPrefs.SetInt("QtdEletrons",ShowElement.eletrons); //onde armazeno a quantidade de eletrons do ususario;
		nEletrons.text = (PlayerPrefs.GetInt("QtdEletrons").ToString());//recebe a quantidade de eletrons armazenados e mostraa;

	}
	void MostrarElemento(){
		Invoke("pararParticulas", 3);

		//Cria o Bromo
		if (K == "2" && L == "8" && M == "18" && N == "8" && O == "0" && P == "0" && Q == "0" && PlayerPrefs.GetInt("QtdEletrons")>= 35){
			elemento2.SetActive(true);
			ShowElement.eletrons=ShowElement.eletrons - 35;
			PlayerPrefs.SetInt("QtdEletrons", ShowElement.eletrons); 
			nEletrons.text = (PlayerPrefs.GetInt("QtdEletrons").ToString());//recebe a quantidade de eletrons armazenados e mostraa;
			ShowElement.Bromo = 1;
			ShowElement.qtdbromo = 1;
			PlayerPrefs.SetInt("Bromo", ShowElement.Bromo);
			jacriou=1;
			botaoCriar.SetActive(false);
		}
		//Cria o Bario
		if (K == "2" && L == "8" && M == "18" && N == "18" && O == "8" && P == "2" && Q == "0" && PlayerPrefs.GetInt("QtdEletrons")>= 56){
			elemento.SetActive(true);
			ShowElement.eletrons=ShowElement.eletrons - 56;
			PlayerPrefs.SetInt("QtdEletrons", ShowElement.eletrons); 
			nEletrons.text = (PlayerPrefs.GetInt("QtdEletrons").ToString());//recebe a quantidade de eletrons armazenados e mostraa;
			ShowElement.Bromo = 1;
			ShowElement.qtdbromo = 1;
			PlayerPrefs.SetInt("Bromo", ShowElement.Bromo);
			jacriou=1;
			botaoCriar.SetActive(false);
		}
		if(jacriou == 0){
			elemento.SetActive(false);
			errorMensage.SetActive(true);
		}
	}
	void pararParticulas(){
		Debug.Log("parou as particulas");
	
		ParticulasNascimento.SetActive(false);
	}
	public void fecharAviso(){
		avisoErro.SetActive(false);
	}
}
