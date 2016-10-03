using UnityEngine.UI;
using UnityEngine;
using System.Collections;

public class Oponente : MonoBehaviour {

	public Image fighterQuatro, fighterCinco, fighterSeis, elementoInimigo;
	private int selected, aux;

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
		Debug.Log(selected);

		if(selected == 0 && aux == 1){
			fighterQuatro.sprite = Resources.Load<Sprite> ("Sprites/"+"Oxigenio")as Sprite;
			elementoInimigo.sprite = Resources.Load<Sprite> ("Sprites/"+"Oxigenio")as Sprite;
			aux = aux+1;
			mostrarInimigos();
		}
		if(selected == 1 && aux == 1){
			fighterQuatro.sprite = Resources.Load<Sprite> ("Sprites/"+"Zinco")as Sprite;
			elementoInimigo.sprite = Resources.Load<Sprite> ("Sprites/"+"Zinco")as Sprite;
			aux = aux+1;
			mostrarInimigos();
		}
		if(selected == 2  && aux == 1){
			fighterQuatro.sprite = Resources.Load<Sprite> ("Sprites/"+"Bromo")as Sprite;
			elementoInimigo.sprite = Resources.Load<Sprite> ("Sprites/"+"Bromo")as Sprite;
			aux = aux+1;
			mostrarInimigos();
		}


		if(selected == 0 && aux == 2f){
			fighterCinco.sprite = Resources.Load<Sprite> ("Sprites/"+"Oxigenio")as Sprite;

			aux = aux+1;
			mostrarInimigos();
		}
		if(selected == 1 && aux == 2f){
			fighterCinco.sprite = Resources.Load<Sprite> ("Sprites/"+"Zinco")as Sprite;
			aux = aux+1;
			mostrarInimigos();
		}
		if(selected == 2  && aux == 2f){
			fighterCinco.sprite = Resources.Load<Sprite> ("Sprites/"+"Bromo")as Sprite;
			aux = aux+1;
			mostrarInimigos();
		}


		if(selected == 0 && aux == 3f){
			fighterSeis.sprite = Resources.Load<Sprite> ("Sprites/"+"Oxigenio")as Sprite;

		}
		if(selected == 1 && aux == 3f){
			fighterSeis.sprite = Resources.Load<Sprite> ("Sprites/"+"Zinco")as Sprite;

		}
		if(selected == 2  && aux == 3f){
			fighterSeis.sprite = Resources.Load<Sprite> ("Sprites/"+"Bromo")as Sprite;
		
		}
		Debug.Log(aux);

	}
	

}
