using UnityEngine.UI;
using UnityEngine;
using System.Collections;

public class Oponente : MonoBehaviour {

	public Image fighterQuatro, fighterCinco, fighterSeis, elementoInimigo;
	private int selected, aux;
	public static float massaAtomicaFloat;
	public static int numeroAtomicoInt;
	public static int ataqueDefesa;

	// Use this for initialization
	void Start () {
		
		aux = 1;
		mostrarInimigos();

	}

	// Update is called once per frame
	void Update () {


	}

	void mostrarInimigos(){
		selected = Random.Range(0,3);
		Debug.Log("A ordem do oponente esta em:"+ selected);

		if(selected == 0 && aux == 1){
			fighterQuatro.sprite = Resources.Load<Sprite> ("Sprites/"+"Oxigenio")as Sprite;
			elementoInimigo.sprite = Resources.Load<Sprite> ("Sprites/"+"Oxigenio")as Sprite;
			PlayerPrefs.SetString("Oponente1", "Oxigenio");
			Oponente.massaAtomicaFloat = 15.9f;
			Oponente.numeroAtomicoInt = 8;
			aux = aux+1;
			Oponente.ataqueDefesa = 1;
			mostrarInimigos();
		}
		if(selected == 1 && aux == 1){
			fighterQuatro.sprite = Resources.Load<Sprite> ("Sprites/"+"Zinco")as Sprite;
			elementoInimigo.sprite = Resources.Load<Sprite> ("Sprites/"+"Zinco")as Sprite;
			aux = aux+1;
			Oponente.massaAtomicaFloat = 65.4f;
			Oponente.numeroAtomicoInt = 30;
			PlayerPrefs.SetString("Oponente1", "Zinco");
			Oponente.ataqueDefesa = 2;
			mostrarInimigos();
		}
		if(selected == 2  && aux == 1){
			fighterQuatro.sprite = Resources.Load<Sprite> ("Sprites/"+"Bromo")as Sprite;
			elementoInimigo.sprite = Resources.Load<Sprite> ("Sprites/"+"Bromo")as Sprite;
			aux = aux+1;
			Oponente.massaAtomicaFloat = 79.9f;
			Oponente.numeroAtomicoInt = 35;
			PlayerPrefs.SetString("Oponente1", "Bromo");
			Oponente.ataqueDefesa = 3;
			mostrarInimigos();
		}


		if(selected == 0 && aux == 2f){
			fighterCinco.sprite = Resources.Load<Sprite> ("Sprites/"+"Oxigenio")as Sprite;
			Oponente.massaAtomicaFloat = 15.9f;
			Oponente.numeroAtomicoInt = 8;
			aux = aux+1;
			PlayerPrefs.SetString("Oponente2", "Oxigenio");
			Oponente.ataqueDefesa = 1;
			mostrarInimigos();
		}
		if(selected == 1 && aux == 2f){
			fighterCinco.sprite = Resources.Load<Sprite> ("Sprites/"+"Zinco")as Sprite;
			aux = aux+1;
			Oponente.massaAtomicaFloat = 65.4f;
			Oponente.numeroAtomicoInt = 30;
			PlayerPrefs.SetString("Oponente2", "Zinco");
			Oponente.ataqueDefesa = 2;
			mostrarInimigos();
		}
		if(selected == 2  && aux == 2f){
			fighterCinco.sprite = Resources.Load<Sprite> ("Sprites/"+"Bromo")as Sprite;
			aux = aux+1;
			Oponente.massaAtomicaFloat = 79.9f;
			Oponente.numeroAtomicoInt = 35;
			Oponente.ataqueDefesa = 3;
			PlayerPrefs.SetString("Oponente2", "Bromo");
			mostrarInimigos();
		}


		if(selected == 0 && aux == 3f){
			fighterSeis.sprite = Resources.Load<Sprite> ("Sprites/"+"Oxigenio")as Sprite;
			Oponente.massaAtomicaFloat = 15.9f;
			Oponente.numeroAtomicoInt = 8;
			Oponente.ataqueDefesa = 1;
		}
		if(selected == 1 && aux == 3f){
			fighterSeis.sprite = Resources.Load<Sprite> ("Sprites/"+"Zinco")as Sprite;
			Oponente.massaAtomicaFloat = 65.4f;
			Oponente.numeroAtomicoInt = 30;
			Oponente.ataqueDefesa = 2;
		}
		if(selected == 2  && aux == 3f){
			fighterSeis.sprite = Resources.Load<Sprite> ("Sprites/"+"Bromo")as Sprite;
			Oponente.massaAtomicaFloat = 79.9f;
			Oponente.numeroAtomicoInt = 35;
			Oponente.ataqueDefesa = 3;
		}
		Debug.Log("O valor de aux eh:"+aux);

	}
	

}
