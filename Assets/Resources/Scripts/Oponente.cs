using UnityEngine.UI;
using UnityEngine;
using System.Collections;

public class Oponente : MonoBehaviour {

	public Image fighterQuatro, fighterCinco, fighterSeis, elementoInimigo;
	private int selected, aux;
	public static float massaAtomicaFloat;
	public static int numeroAtomicoInt;
	public static int ataqueDefesa, oponenteSegundo, oponenteTerceiro;

	// Use this for initialization
	void Start () {
		
		aux = 1;
		mostrarInimigos();

	}

	// Update is called once per frame
	void Update () {


	}

	void mostrarInimigos(){
		selected = Random.Range(0,4);


		if(selected == 0 && aux == 1){
			fighterQuatro.sprite = Resources.Load<Sprite> ("Sprites/"+"oxigenio_face")as Sprite;
			elementoInimigo.sprite = Resources.Load<Sprite> ("Sprites/"+"Oxigenio")as Sprite;
			PlayerPrefs.SetString("Oponente1", "Oxigenio");
			Oponente.massaAtomicaFloat = 15.9f;
			Oponente.numeroAtomicoInt = 8;
			aux = aux+1;
			Oponente.ataqueDefesa = 1;
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
			mostrarInimigos();
		}


		if(selected == 0 && aux == 2f){
			fighterCinco.sprite = Resources.Load<Sprite> ("Sprites/"+"oxigenio_face")as Sprite;
			Oponente.massaAtomicaFloat = 15.9f;
			Oponente.numeroAtomicoInt = 8;
			aux = aux+1;
			PlayerPrefs.SetString("Oponente2", "Oxigenio");
			Oponente.oponenteSegundo = 1;
			mostrarInimigos();
		}
		if(selected == 1 && aux == 2f){
			fighterCinco.sprite = Resources.Load<Sprite> ("Sprites/"+"zinco_face")as Sprite;
			aux = aux+1;
			Oponente.massaAtomicaFloat = 65.4f;
			Oponente.numeroAtomicoInt = 30;
			PlayerPrefs.SetString("Oponente2", "Zinco");
			Oponente.oponenteSegundo = 2;
			mostrarInimigos();
		}
		if(selected == 2  && aux == 2f){
			fighterCinco.sprite = Resources.Load<Sprite> ("Sprites/"+"bromo_face")as Sprite;
			aux = aux+1;
			Oponente.massaAtomicaFloat = 79.9f;
			Oponente.numeroAtomicoInt = 35;
			PlayerPrefs.SetString("Oponente2", "Bromo");
			Oponente.oponenteSegundo = 3;
			mostrarInimigos();
		}
		if(selected == 3  && aux == 2f){
			fighterCinco.sprite = Resources.Load<Sprite> ("Sprites/"+"boro_face")as Sprite;

			aux = aux+1;
			Oponente.massaAtomicaFloat = 10.8f;
			Oponente.numeroAtomicoInt = 5 ;
			PlayerPrefs.SetString("Oponente2", "Boro");
			Oponente.ataqueDefesa = 4;
			mostrarInimigos();
		}


		if(selected == 0 && aux == 3f){
			fighterSeis.sprite = Resources.Load<Sprite> ("Sprites/"+"oxigenio_face")as Sprite;
			Oponente.massaAtomicaFloat = 15.9f;
			Oponente.numeroAtomicoInt = 8;
			PlayerPrefs.SetString("Oponente3", "Oxigenio");
			Oponente.oponenteTerceiro = 1;
		}
		if(selected == 1 && aux == 3f){
			fighterSeis.sprite = Resources.Load<Sprite> ("Sprites/"+"zinco_face")as Sprite;
			Oponente.massaAtomicaFloat = 65.4f;
			Oponente.numeroAtomicoInt = 30;
			PlayerPrefs.SetString("Oponente3", "Zinco");
			Oponente.oponenteTerceiro = 2;
		}
		if(selected == 2  && aux == 3f){
			fighterSeis.sprite = Resources.Load<Sprite> ("Sprites/"+"bromo_face")as Sprite;
			Oponente.massaAtomicaFloat = 79.9f;
			Oponente.numeroAtomicoInt = 35;
			PlayerPrefs.SetString("Oponente3", "Bromo");
			Oponente.oponenteTerceiro = 3;
		}
		if(selected == 3  && aux == 3f){
			fighterSeis.sprite = Resources.Load<Sprite> ("Sprites/"+"boro_face")as Sprite;

			Oponente.massaAtomicaFloat = 10.8f;
			Oponente.numeroAtomicoInt = 5 ;
			PlayerPrefs.SetString("Oponente3", "Boro");
			Oponente.ataqueDefesa = 4;
			mostrarInimigos();
		}


	}
	

}
