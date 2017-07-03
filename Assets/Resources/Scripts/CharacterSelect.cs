using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CharacterSelect : MonoBehaviour {

	public Image fighter, fighter2, fighter3;
	private int aux, i;
	public string lutador1, lutador2, lutador3;
	public GameObject battle, anim1, anim2, anim3;
	public GameObject[] botoes;
	//public GameObject lutador1, lutador2, lutador3;

	// Use this for initialization
	void Start () {
		aux = 0;
	}
	void Update () {

	}

	public void ChangeImagefirst(string nameImage){



		if(aux == 2 ){
			fighter3.sprite = Resources.Load<Sprite> ("Sprites/"+nameImage)as Sprite;
			battle.SetActive(true);
			PlayerPrefs.SetString("Lutador3", nameImage);
			//lutador3 = Resources.Load<GameObject> ("Prefabs/"+nameImage)as GameObject;
			anim3.GetComponent<Animator>().Play("Primeiro_Becker");
			GameObject.Find(nameImage).SetActive(false);
			lutador3 = nameImage;
		}
		if(aux == 1 ){
			fighter2.sprite = Resources.Load<Sprite> ("Sprites/"+nameImage)as Sprite;
			aux = aux+1;
			//lutador2 = Resources.Load<GameObject> ("Prefabs/"+nameImage)as GameObject;
			PlayerPrefs.SetString("Lutador2", nameImage);
			anim2.GetComponent<Animator>().Play("Primeiro_Becker");
			GameObject.Find(nameImage).SetActive(false);
			lutador2 = nameImage;
		}
		if(aux == 0){
			fighter.sprite = Resources.Load<Sprite> ("Sprites/"+nameImage)as Sprite;
			aux = 1;
			PlayerPrefs.SetString("Lutador1", nameImage);
			//lutador1 = Resources.Load<GameObject> ("Prefabs/"+nameImage)as GameObject;
			anim1.GetComponent<Animator>().Play("Primeiro_Becker");
			GameObject.Find(nameImage).SetActive(false);
			lutador1 = nameImage;
		}

		//this.GetComponent<Button> ().enabled = false;
		Debug.Log ("entrou aki");
	}

	public void ZerarPlayers(){
		this.aux = 0;
		for(i=0; i< 13; i++)
		{
			botoes[i].SetActive(true);
		}
		fighter.sprite = Resources.Load<Sprite> ("Sprites/Hud/becker")as Sprite;			
		fighter2.sprite =Resources.Load<Sprite> ("Sprites/Hud/becker")as Sprite;	
		fighter3.sprite = Resources.Load<Sprite> ("Sprites/Hud/becker")as Sprite;

		battle.SetActive(false);
	}

}

