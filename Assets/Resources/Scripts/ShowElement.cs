using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ShowElement : MonoBehaviour {

	public GameObject elemento, elemento2, elemento3, elemento4, elemento5, ParticulasNascimento, botaoCriar,avisoErro, Explosion, camera, MensageClone;
	public string K, L, M, N, O, P, Q,aux_string;
	public Text nEletrons;
	public static int eletrons, jacriou;
	public static int Bromo, qtdbromo;

	public GameObject errorMensage, elemento6, elemento7, elemento8, elemento9, elemento10, elemento11;

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
		camera.GetComponent<Animator> ().Play ("TremeCamera");
  }
	void aumentarEletrons(){
	
		ShowElement.eletrons = ShowElement.eletrons+10;
		PlayerPrefs.SetInt("QtdEletrons",ShowElement.eletrons); //onde armazeno a quantidade de eletrons do ususario;
		nEletrons.text = (PlayerPrefs.GetInt("QtdEletrons").ToString());//recebe a quantidade de eletrons armazenados e mostraa;

	}
	void MostrarElemento(){
		Invoke("pararParticulas", 3);
		Explosion.SetActive (true);

		//Cria o Bromo
		if (K == "2" && L == "8" && M == "18" && N == "7" && O == "0" && P == "0" && Q == "0" && PlayerPrefs.GetInt("QtdEletrons")>= 35 && PlayerPrefs.GetInt("Bromo") == 0)
        {
			elemento2.SetActive(true);
			ShowElement.eletrons=ShowElement.eletrons - 35;
			PlayerPrefs.SetInt("QtdEletrons", ShowElement.eletrons); 
			nEletrons.text = (PlayerPrefs.GetInt("QtdEletrons").ToString());//recebe a quantidade de eletrons armazenados e mostraa;
			//ShowElement.Bromo = 1;
			//ShowElement.qtdbromo = 1;
			//PlayerPrefs.SetInt("Bromo", ShowElement.Bromo);
			jacriou=1;
			botaoCriar.SetActive(false);
		}
        if (K == "2" && L == "8" && M == "18" && N == "7" && O == "0" && P == "0" && Q == "0" && PlayerPrefs.GetInt("QtdEletrons") >= 35 && PlayerPrefs.GetInt("Bromo") == 1)
        {
            Debug.Log("criou um clone");
            // MensageClone.SetActive(true);
            jacriou = 1;
        }
            //Cria o Bario
            if (K == "2" && L == "8" && M == "18" && N == "18" && O == "8" && P == "2" && Q == "0" && PlayerPrefs.GetInt("QtdEletrons")>= 56 && PlayerPrefs.GetInt("Bario") == 0)
        {
			elemento.SetActive(true);
			ShowElement.eletrons=ShowElement.eletrons - 56;
			PlayerPrefs.SetInt("QtdEletrons", ShowElement.eletrons); 
			nEletrons.text = (PlayerPrefs.GetInt("QtdEletrons").ToString());//recebe a quantidade de eletrons armazenados e mostraa;
			//ShowElement.Bromo = 1;
			//ShowElement.qtdbromo = 1;
			//PlayerPrefs.SetInt("Bromo", ShowElement.Bromo);
			jacriou=1;
			botaoCriar.SetActive(false);
		}
        if (K == "2" && L == "8" && M == "18" && N == "18" && O == "8" && P == "2" && Q == "0" && PlayerPrefs.GetInt("QtdEletrons") >= 56 && PlayerPrefs.GetInt("Bario") == 1)
        {
            jacriou = 1;
        }
            //Cria o Boro
            if (K == "2" && L == "3" && M == "0" && N == "0" && O == "0" && P == "0" && Q == "0" && PlayerPrefs.GetInt("QtdEletrons")>= 5){
			elemento3.SetActive(true);
			ShowElement.eletrons=ShowElement.eletrons - 5;
			PlayerPrefs.SetInt("QtdEletrons", ShowElement.eletrons); 
			nEletrons.text = (PlayerPrefs.GetInt("QtdEletrons").ToString());//recebe a quantidade de eletrons armazenados e mostraa;
			//ShowElement.Bromo = 1;
			//ShowElement.qtdbromo = 1;
			//PlayerPrefs.SetInt("Bromo", ShowElement.Bromo);
			jacriou=1;
			PlayerPrefs.SetInt ("Boro", 1);
			botaoCriar.SetActive(false);
		}
		//Cria o Carbono
		if (K == "2" && L == "4" && M == "0" && N == "0" && O == "0" && P == "0" && Q == "0" && PlayerPrefs.GetInt("QtdEletrons")>= 6){
			elemento4.SetActive(true);
			ShowElement.eletrons=ShowElement.eletrons - 6;
			PlayerPrefs.SetInt("QtdEletrons", ShowElement.eletrons); 
			nEletrons.text = (PlayerPrefs.GetInt("QtdEletrons").ToString());//recebe a quantidade de eletrons armazenados e mostraa;
			//ShowElement.Bromo = 1;
			//ShowElement.qtdbromo = 1;
			//PlayerPrefs.SetInt("Bromo", ShowElement.Bromo);
			jacriou=1;
			PlayerPrefs.SetInt ("Carbono", 1);
			botaoCriar.SetActive(false);
		}
		//Cria o Cesio
		if (K == "2" && L == "8" && M == "18" && N == "18" && O == "8" && P == "1" && Q == "0" && PlayerPrefs.GetInt("QtdEletrons")>= 55){
			elemento5.SetActive(true);
			ShowElement.eletrons=ShowElement.eletrons - 55;
			PlayerPrefs.SetInt("QtdEletrons", ShowElement.eletrons); 
			nEletrons.text = (PlayerPrefs.GetInt("QtdEletrons").ToString());//recebe a quantidade de eletrons armazenados e mostraa;
			//ShowElement.Bromo = 1;
			//ShowElement.qtdbromo = 1;
			//PlayerPrefs.SetInt("Bromo", ShowElement.Bromo);
			jacriou=1;
			PlayerPrefs.SetInt ("Cesio", 1);
			botaoCriar.SetActive(false);
		}
		//Cria o Kriptonio
		if (K == "2" && L == "8" && M == "18" && N == "8" && O == "0" && P == "0" && Q == "0" && PlayerPrefs.GetInt("QtdEletrons")>= 36){
			elemento6.SetActive(true);
			ShowElement.eletrons=ShowElement.eletrons - 36;
			PlayerPrefs.SetInt("QtdEletrons", ShowElement.eletrons); 
			nEletrons.text = (PlayerPrefs.GetInt("QtdEletrons").ToString());//recebe a quantidade de eletrons armazenados e mostraa;
			//ShowElement.Bromo = 1;
			//ShowElement.qtdbromo = 1;
			//PlayerPrefs.SetInt("Bromo", ShowElement.Bromo);
			jacriou=1;
			PlayerPrefs.SetInt ("Criptonio", 1);
			botaoCriar.SetActive(false);
		}
		//Cria o Hélio
		if (K == "2" && L == "0" && M == "0" && N == "0" && O == "0" && P == "0" && Q == "0" && PlayerPrefs.GetInt("QtdEletrons")>= 2){
			elemento7.SetActive(true);
			ShowElement.eletrons=ShowElement.eletrons - 2;
			PlayerPrefs.SetInt("QtdEletrons", ShowElement.eletrons); 
			nEletrons.text = (PlayerPrefs.GetInt("QtdEletrons").ToString());//recebe a quantidade de eletrons armazenados e mostraa;
			//ShowElement.Bromo = 1;
			//ShowElement.qtdbromo = 1;
			//PlayerPrefs.SetInt("Bromo", ShowElement.Bromo);
			jacriou=1;
			PlayerPrefs.SetInt ("Helio", 1);
			botaoCriar.SetActive(false);
		}
		//Cria o Litio
		if (K == "2" && L == "1" && M == "0" && N == "0" && O == "0" && P == "0" && Q == "0" && PlayerPrefs.GetInt("QtdEletrons")>= 3){
			elemento8.SetActive(true);
			ShowElement.eletrons=ShowElement.eletrons - 3;
			PlayerPrefs.SetInt("QtdEletrons", ShowElement.eletrons); 
			nEletrons.text = (PlayerPrefs.GetInt("QtdEletrons").ToString());//recebe a quantidade de eletrons armazenados e mostraa;
			//ShowElement.Bromo = 1;
			//ShowElement.qtdbromo = 1;
			//PlayerPrefs.SetInt("Bromo", ShowElement.Bromo);
			jacriou=1;
			PlayerPrefs.SetInt ("Litio", 1);
			botaoCriar.SetActive(false);
		}
		//Cria o Neon
		if (K == "2" && L == "8" && M == "0" && N == "0" && O == "0" && P == "0" && Q == "0" && PlayerPrefs.GetInt("QtdEletrons")>= 10){
			elemento9.SetActive(true);
			ShowElement.eletrons=ShowElement.eletrons - 10;
			PlayerPrefs.SetInt("QtdEletrons", ShowElement.eletrons); 
			nEletrons.text = (PlayerPrefs.GetInt("QtdEletrons").ToString());//recebe a quantidade de eletrons armazenados e mostraa;
			//ShowElement.Bromo = 1;
			//ShowElement.qtdbromo = 1;
			//PlayerPrefs.SetInt("Bromo", ShowElement.Bromo);
			jacriou=1;
			PlayerPrefs.SetInt ("Neon", 1);
			botaoCriar.SetActive(false);
		}
		//Cria o Selenio
		if (K == "2" && L == "8" && M == "18" && N == "6" && O == "0" && P == "0" && Q == "0" && PlayerPrefs.GetInt("QtdEletrons")>= 34){
			elemento10.SetActive(true);
			ShowElement.eletrons=ShowElement.eletrons - 34;
			PlayerPrefs.SetInt("QtdEletrons", ShowElement.eletrons); 
			nEletrons.text = (PlayerPrefs.GetInt("QtdEletrons").ToString());//recebe a quantidade de eletrons armazenados e mostraa;
			//ShowElement.Bromo = 1;
			//ShowElement.qtdbromo = 1;
			//PlayerPrefs.SetInt("Bromo", ShowElement.Bromo);
			jacriou=1;
			PlayerPrefs.SetInt ("Selenio", 1);
			botaoCriar.SetActive(false);
		}
		//Cria o Xenonio
		if (K == "2" && L == "8" && M == "18" && N == "18" && O == "8" && P == "0" && Q == "0" && PlayerPrefs.GetInt("QtdEletrons")>= 54){
			elemento11.SetActive(true);
			ShowElement.eletrons=ShowElement.eletrons - 54;
			PlayerPrefs.SetInt("QtdEletrons", ShowElement.eletrons); 
			nEletrons.text = (PlayerPrefs.GetInt("QtdEletrons").ToString());//recebe a quantidade de eletrons armazenados e mostraa;
			//ShowElement.Bromo = 1;
			//ShowElement.qtdbromo = 1;
			//PlayerPrefs.SetInt("Bromo", ShowElement.Bromo);
			jacriou=1;
			PlayerPrefs.SetInt ("Xenonio", 1);
			botaoCriar.SetActive(false);
		}
		if(jacriou == 0){
			elemento.SetActive(false);
			errorMensage.SetActive(true);
		}
	}
	void pararParticulas(){
		Debug.Log("parou as particulas");
		Explosion.SetActive (false);
		ParticulasNascimento.SetActive(false);
	}
	public void fecharAviso(){
		avisoErro.SetActive(false);
	}
}
