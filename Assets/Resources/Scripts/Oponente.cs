using UnityEngine.UI;
using UnityEngine;
using System.Collections;

public class Oponente : MonoBehaviour {

	public Image fighterQuatro, fighterCinco, fighterSeis, elementoInimigo;
	private int selected, aux;
	public static float massaAtomicaFloat;
	public static int numeroAtomicoInt;
	public static int ataqueDefesa, oponenteSegundo, oponenteTerceiro;
	public Text nomeInimigo;
	public static string faseSeelecionada, faseBoss;
	private int i;

	// Use this for initialization
	void Start () {
		inimigosFase ();
		Boss1 ();
	}

	// Update is called once per frame
	void Update () {


	}
	public void setarArgumento(int aux){
		PlayerPrefs.SetInt("auxHistorico",aux);
	}

	public void SetarBoss(string qualBoss){
		PlayerPrefs.SetString ("Boss", qualBoss);
	
	}
	public void SetarLutinha(string qualLutinha){
		PlayerPrefs.SetString ("Lutinha", qualLutinha);
		PlayerPrefs.SetString ("Boss", "vazio");

	}

	void inimigosFase(){
		for (i=0; i < 26; i++) {
			if (PlayerPrefs.GetString("Lutinha") == "fase1"){
				fighterQuatro.sprite = Resources.Load<Sprite> ("Sprites/" + "bromo_face")as Sprite;
				elementoInimigo.sprite = Resources.Load<Sprite> ("Sprites/" + "Bromo")as Sprite;
				PlayerPrefs.SetString ("Oponente1", "Bromo");
				nomeInimigo.text = "Bromo";

				fighterCinco.sprite = Resources.Load<Sprite> ("Sprites/" + "bromo_face")as Sprite;
				PlayerPrefs.SetString ("Oponente2", "Bromo");

				fighterSeis.sprite = Resources.Load<Sprite> ("Sprites/" + "bromo_face")as Sprite;
				PlayerPrefs.SetString ("Oponente3", "Bromo");
			}
			if (PlayerPrefs.GetString("Lutinha") == "fase2"){
				fighterQuatro.sprite = Resources.Load<Sprite> ("Sprites/" + "oxigenio_face")as Sprite;
				elementoInimigo.sprite = Resources.Load<Sprite> ("Sprites/" + "Oxigenio")as Sprite;
				PlayerPrefs.SetString ("Oponente1", "Oxigenio");
				nomeInimigo.text = "Oxigenio";

				fighterCinco.sprite = Resources.Load<Sprite> ("Sprites/" + "oxigenio_face")as Sprite;
				PlayerPrefs.SetString ("Oponente2", "Oxigenio");

				fighterSeis.sprite = Resources.Load<Sprite> ("Sprites/" + "zinco_face")as Sprite;
				PlayerPrefs.SetString ("Oponente3", "Zinco");
			}
		}
	}
	void Boss1(){
		for (i = 0; i < 13; i++) {
			if (PlayerPrefs.GetString("Boss") == "boss1") {
				fighterQuatro.sprite = Resources.Load<Sprite> ("Sprites/" + "helio_face")as Sprite;
				elementoInimigo.sprite = Resources.Load<Sprite> ("Sprites/" + "Helio")as Sprite;
				PlayerPrefs.SetString ("Boss", "Helio");
				nomeInimigo.text = "Hélio";
			}
			if (PlayerPrefs.GetString("Boss") == "boss2") {
				fighterQuatro.sprite = Resources.Load<Sprite> ("Sprites/" + "litio_face")as Sprite;
				elementoInimigo.sprite = Resources.Load<Sprite> ("Sprites/" + "Litio")as Sprite;
				PlayerPrefs.SetString ("Boss", "Litio");
				nomeInimigo.text = "Lítio";
			}
			if (PlayerPrefs.GetString("Boss") == "boss3") {
				fighterQuatro.sprite = Resources.Load<Sprite> ("Sprites/" + "boro_face")as Sprite;
				elementoInimigo.sprite = Resources.Load<Sprite> ("Sprites/" + "Boro")as Sprite;
				PlayerPrefs.SetString ("Boss", "Boro");
				nomeInimigo.text = "Boro";
			}
			if (PlayerPrefs.GetString("Boss") == "boss4") {
				fighterQuatro.sprite = Resources.Load<Sprite> ("Sprites/" + "carbono_face")as Sprite;
				elementoInimigo.sprite = Resources.Load<Sprite> ("Sprites/" + "Carbono")as Sprite;
				PlayerPrefs.SetString ("Boss", "Carbono");
				nomeInimigo.text = "Carbono";
			}
			if (PlayerPrefs.GetString("Boss") == "boss5") {
				fighterQuatro.sprite = Resources.Load<Sprite> ("Sprites/" + "oxigenio_face")as Sprite;
				elementoInimigo.sprite = Resources.Load<Sprite> ("Sprites/" + "Oxigenio")as Sprite;
				PlayerPrefs.SetString ("Boss", "Oxigenio");
				nomeInimigo.text = "Oxigênio";
			}
			if (PlayerPrefs.GetString("Boss") == "boss6") {
				fighterQuatro.sprite = Resources.Load<Sprite> ("Sprites/" + "neon_face")as Sprite;
				elementoInimigo.sprite = Resources.Load<Sprite> ("Sprites/" + "Neon")as Sprite;
				PlayerPrefs.SetString ("Boss", "Neon");
				nomeInimigo.text = "Neon";
			}
			if (PlayerPrefs.GetString("Boss") == "boss7") {
				fighterQuatro.sprite = Resources.Load<Sprite> ("Sprites/" + "zinco_face")as Sprite;
				elementoInimigo.sprite = Resources.Load<Sprite> ("Sprites/" + "Zinco")as Sprite;
				PlayerPrefs.SetString ("Boss", "Zinco");
				nomeInimigo.text = "Zinco";
			}
			if (PlayerPrefs.GetString("Boss") == "boss8") {
				fighterQuatro.sprite = Resources.Load<Sprite> ("Sprites/" + "selenio_face")as Sprite;
				elementoInimigo.sprite = Resources.Load<Sprite> ("Sprites/" + "Selenio")as Sprite;
				PlayerPrefs.SetString ("Boss", "Selenio");
				nomeInimigo.text = "Selênio";
			}
			if (PlayerPrefs.GetString("Boss") == "boss9") {
				fighterQuatro.sprite = Resources.Load<Sprite> ("Sprites/" + "bromo_face")as Sprite;
				elementoInimigo.sprite = Resources.Load<Sprite> ("Sprites/" + "Bromo")as Sprite;
				PlayerPrefs.SetString ("Boss", "Bromo");
				nomeInimigo.text = "Bromo";
			}
			if (PlayerPrefs.GetString("Boss") == "boss10") {
				fighterQuatro.sprite = Resources.Load<Sprite> ("Sprites/" + "criptonio_face")as Sprite;
				elementoInimigo.sprite = Resources.Load<Sprite> ("Sprites/" + "Criptonio")as Sprite;
				PlayerPrefs.SetString ("Boss", "Criptonio");
				nomeInimigo.text = "Criptônio";
			}
			if (PlayerPrefs.GetString("Boss") == "boss11") {
				fighterQuatro.sprite = Resources.Load<Sprite> ("Sprites/" + "xenonio_face")as Sprite;
				elementoInimigo.sprite = Resources.Load<Sprite> ("Sprites/" + "Xenonio")as Sprite;
				PlayerPrefs.SetString ("Boss", "Xenonio");
				nomeInimigo.text = "Xenônio";
			}
			if (PlayerPrefs.GetString("Boss") == "boss12") {
				fighterQuatro.sprite = Resources.Load<Sprite> ("Sprites/" + "cesio_face")as Sprite;
				elementoInimigo.sprite = Resources.Load<Sprite> ("Sprites/" + "Cesio")as Sprite;
				PlayerPrefs.SetString ("Boss", "Cesio");
				nomeInimigo.text = "Césio";
			}
			if (PlayerPrefs.GetString("Boss") == "boss13") {
				fighterQuatro.sprite = Resources.Load<Sprite> ("Sprites/" + "bario_face")as Sprite;
				elementoInimigo.sprite = Resources.Load<Sprite> ("Sprites/" + "Bario")as Sprite;
				PlayerPrefs.SetString ("Boss", "Bario");
				nomeInimigo.text = "Bário";
			}
		}
	}


	/*void mostrarInimigos(){
		selected = Random.Range(0,4);
		 

		if(selected == 0 && aux == 1){
			fighterQuatro.sprite = Resources.Load<Sprite> ("Sprites/"+"oxigenio_face")as Sprite;
			elementoInimigo.sprite = Resources.Load<Sprite> ("Sprites/"+"Oxigenio")as Sprite;
			PlayerPrefs.SetString("Oponente1", "Oxigenio");
			Oponente.massaAtomicaFloat = 15.9f;
			Oponente.numeroAtomicoInt = 8;
			aux = aux+1;
			Oponente.ataqueDefesa = 1;
			nomeInimigo.text = "Oxigenio";
			mostrarInimigos();
		}
		if(selected == 1 && aux == 1){
			fighterQuatro.sprite = Resources.Load<Sprite> ("Sprites/"+"zinco_face")as Sprite;
			elementoInimigo.sprite = Resources.Load<Sprite> ("Sprites/"+"Zinco")as Sprite;
			aux = aux+1;
			Oponente.massaAtomicaFloat = 65.4f;
			Oponente.numeroAtomicoInt = 30;
			PlayerPrefs.SetString("Oponente1", "Zinco");
			Oponente.ataqueDefesa = 2;
			nomeInimigo.text = "Zinco";
			mostrarInimigos();
		}
		if(selected == 2  && aux == 1){
			fighterQuatro.sprite = Resources.Load<Sprite> ("Sprites/"+"bromo_face")as Sprite;
			elementoInimigo.sprite = Resources.Load<Sprite> ("Sprites/"+"Bromo")as Sprite;
			aux = aux+1;
			Oponente.massaAtomicaFloat = 79.9f;
			Oponente.numeroAtomicoInt = 35;
			PlayerPrefs.SetString("Oponente1", "Bromo");
			Oponente.ataqueDefesa = 3;
			nomeInimigo.text = "Bromo";
			mostrarInimigos();
		}
		if(selected == 3  && aux == 1){
			fighterQuatro.sprite = Resources.Load<Sprite> ("Sprites/"+"boro_face")as Sprite;
			elementoInimigo.sprite = Resources.Load<Sprite> ("Sprites/"+"Boro")as Sprite;
			aux = aux+1;
			Oponente.massaAtomicaFloat = 10.8f;
			Oponente.numeroAtomicoInt = 5 ;
			PlayerPrefs.SetString("Oponente1", "Boro");
			Oponente.ataqueDefesa = 4;
			nomeInimigo.text = "Boro";
			mostrarInimigos();
		}


		if(selected == 0 && aux == 2f){
			fighterCinco.sprite = Resources.Load<Sprite> ("Sprites/"+"oxigenio_face")as Sprite;
			Oponente.massaAtomicaFloat = 15.9f;
			Oponente.numeroAtomicoInt = 8;
			aux = aux+1;
			PlayerPrefs.SetString("Oponente2", "Oxigenio");
			Oponente.oponenteSegundo = 1;
			//nomeInimigo.text = "Oxigenio";
			mostrarInimigos();
		}
		if(selected == 1 && aux == 2f){
			fighterCinco.sprite = Resources.Load<Sprite> ("Sprites/"+"zinco_face")as Sprite;
			aux = aux+1;
			Oponente.massaAtomicaFloat = 65.4f;
			Oponente.numeroAtomicoInt = 30;
			PlayerPrefs.SetString("Oponente2", "Zinco");
			Oponente.oponenteSegundo = 2;
			//nomeInimigo.text = "Zinco";
			mostrarInimigos();
		}
		if(selected == 2  && aux == 2f){
			fighterCinco.sprite = Resources.Load<Sprite> ("Sprites/"+"bromo_face")as Sprite;
			aux = aux+1;
			Oponente.massaAtomicaFloat = 79.9f;
			Oponente.numeroAtomicoInt = 35;
			PlayerPrefs.SetString("Oponente2", "Bromo");
			Oponente.oponenteSegundo = 3;
			//nomeInimigo.text = "Bromo";
			mostrarInimigos();
		}
		if(selected == 3  && aux == 2f){
			fighterCinco.sprite = Resources.Load<Sprite> ("Sprites/"+"boro_face")as Sprite;

			aux = aux+1;
			Oponente.massaAtomicaFloat = 10.8f;
			Oponente.numeroAtomicoInt = 5 ;
			PlayerPrefs.SetString("Oponente2", "Boro");
			Oponente.ataqueDefesa = 4;
			//nomeInimigo.text = "Boro";
			mostrarInimigos();
		}


		if(selected == 0 && aux == 3f){
			fighterSeis.sprite = Resources.Load<Sprite> ("Sprites/"+"oxigenio_face")as Sprite;
			Oponente.massaAtomicaFloat = 15.9f;
			Oponente.numeroAtomicoInt = 8;
			PlayerPrefs.SetString("Oponente3", "Oxigenio");
			//nomeInimigo.text = "Oxigenio";
			Oponente.oponenteTerceiro = 1;
		}
		if(selected == 1 && aux == 3f){
			fighterSeis.sprite = Resources.Load<Sprite> ("Sprites/"+"zinco_face")as Sprite;
			Oponente.massaAtomicaFloat = 65.4f;
			Oponente.numeroAtomicoInt = 30;
			PlayerPrefs.SetString("Oponente3", "Zinco");
			//nomeInimigo.text = "Zinco";
			Oponente.oponenteTerceiro = 2;
		}
		if(selected == 2  && aux == 3f){
			fighterSeis.sprite = Resources.Load<Sprite> ("Sprites/"+"bromo_face")as Sprite;
			Oponente.massaAtomicaFloat = 79.9f;
			Oponente.numeroAtomicoInt = 35;
			PlayerPrefs.SetString("Oponente3", "Bromo");
			//nomeInimigo.text = "Bromo";
			Oponente.oponenteTerceiro = 3;
		}
		if(selected == 3  && aux == 3f){
			fighterSeis.sprite = Resources.Load<Sprite> ("Sprites/"+"boro_face")as Sprite;

			Oponente.massaAtomicaFloat = 10.8f;
			Oponente.numeroAtomicoInt = 5 ;
			PlayerPrefs.SetString("Oponente3", "Boro");
			Oponente.oponenteTerceiro = 4;
			//nomeInimigo.text = "Boro";
			mostrarInimigos();
		}


	}*/
	

}
