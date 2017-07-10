using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AtivarElementosBoss : MonoBehaviour {

	public Image fighter, fighterDois, fighterTres;
	//public GameObject bromo, zinco, oxigenio, bario;
	private int ativaosFigheters;

	// Use this for initialization
	void Start () {
		AtivarFighters();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void AtivarFighters(){			

		if (PlayerPrefs.GetString ("Lutador1") == "Oxigenio") {
			fighter.sprite = Resources.Load<Sprite> ("Sprites/"+"Oxigenio")as Sprite;
			ativaosFigheters = ativaosFigheters +1;
		}if (PlayerPrefs.GetString ("Lutador2") == "Oxigenio") {
			fighterDois.sprite = Resources.Load<Sprite> ("Sprites/"+"Oxigenio")as Sprite;
			ativaosFigheters = ativaosFigheters +1;
		}if (PlayerPrefs.GetString ("Lutador3") == "Oxigenio") {
			fighterTres.sprite = Resources.Load<Sprite> ("Sprites/"+"Oxigenio")as Sprite;
			ativaosFigheters = ativaosFigheters +1;
		}

		if (PlayerPrefs.GetString ("Lutador1") == "Bromo") {
			fighter.sprite = Resources.Load<Sprite> ("Sprites/"+"Bromo")as Sprite;
			ativaosFigheters = ativaosFigheters +1;
		}if (PlayerPrefs.GetString ("Lutador2") == "Bromo") {
			fighterDois.sprite = Resources.Load<Sprite> ("Sprites/"+"Bromo")as Sprite;
			ativaosFigheters = ativaosFigheters +1;
		}if (PlayerPrefs.GetString ("Lutador3") == "Bromo") {
			fighterTres.sprite = Resources.Load<Sprite> ("Sprites/"+"Bromo")as Sprite;
			ativaosFigheters = ativaosFigheters +1;
		}

		if (PlayerPrefs.GetString ("Lutador1") == "Zinco") {
			fighter.sprite = Resources.Load<Sprite> ("Sprites/"+"Zinco")as Sprite;
			ativaosFigheters = ativaosFigheters +1;
		}if (PlayerPrefs.GetString ("Lutador2") == "Zinco") {
			fighterDois.sprite = Resources.Load<Sprite> ("Sprites/"+"Zinco")as Sprite;
			ativaosFigheters = ativaosFigheters +1;
		}if (PlayerPrefs.GetString ("Lutador3") == "Zinco") {
			fighterTres.sprite = Resources.Load<Sprite> ("Sprites/"+"Zinco")as Sprite;
			ativaosFigheters = ativaosFigheters +1;
		}

		if (PlayerPrefs.GetString ("Lutador1") == "Bario") {
			fighter.sprite = Resources.Load<Sprite> ("Sprites/"+"Bario")as Sprite;
			ativaosFigheters = ativaosFigheters +1;
		}if (PlayerPrefs.GetString ("Lutador2") == "Bario") {
			fighterDois.sprite = Resources.Load<Sprite> ("Sprites/"+"Bario")as Sprite;
			ativaosFigheters = ativaosFigheters +1;
		}if (PlayerPrefs.GetString ("Lutador3") == "Bario") {
			fighterTres.sprite = Resources.Load<Sprite> ("Sprites/"+"Bario")as Sprite;
			ativaosFigheters = ativaosFigheters +1;
		}
		if(ativaosFigheters != 3){
			Debug.Log ("akiiii");
			AtivarFighters();
		}

		/*if (PlayerPrefs.GetString ("Lutador1") == "Bromo") {
			bromo.SetActive (true);
			bromo.transform.position = new Vector3 (fighter.transform.position.x, fighter.transform.position.y, 0);
			ativaosFigheters = ativaosFigheters +1;
		}if (PlayerPrefs.GetString ("Lutador2") == "Bromo") {
			bromo.SetActive (true);
			bromo.transform.position = new Vector3 (fighterDois.transform.position.x, fighterDois.transform.position.y, 0);
			ativaosFigheters = ativaosFigheters +1;
		}if (PlayerPrefs.GetString ("Lutador3") == "Bromo") {
			bromo.SetActive (true);
			bromo.transform.position = new Vector3 (fighterTres.transform.position.x, fighterTres.transform.position.y, 0);
			ativaosFigheters = ativaosFigheters +1;

		}
		if (PlayerPrefs.GetString ("Lutador1") == "Zinco") {
			zinco.SetActive (true);
			zinco.transform.position = new Vector3 (fighter.transform.position.x, fighter.transform.position.y, 0);
			ativaosFigheters = ativaosFigheters +1;
		}if (PlayerPrefs.GetString ("Lutador2") == "Zinco") {
			zinco.SetActive (true);
			zinco.transform.position = new Vector3 (fighterDois.transform.position.x, fighterDois.transform.position.y, 0);
			ativaosFigheters = ativaosFigheters +1;
		}if (PlayerPrefs.GetString ("Lutador3") == "Zinco") {
			zinco.SetActive (true);
			zinco.transform.position = new Vector3 (fighterTres.transform.position.x, fighterTres.transform.position.y, 0);
			ativaosFigheters = ativaosFigheters +1;
		}
		if (PlayerPrefs.GetString ("Lutador1") == "Bario") {
			bario.SetActive (true);
			bario.transform.position = new Vector3 (fighter.transform.position.x, fighter.transform.position.y, 0);
			ativaosFigheters = ativaosFigheters +1;
		}if (PlayerPrefs.GetString ("Lutador2") == "Bario") {
			bario.SetActive (true);
			bario.transform.position = new Vector3 (fighterDois.transform.position.x, fighterDois.transform.position.y, 0);
			ativaosFigheters = ativaosFigheters +1;
		}if (PlayerPrefs.GetString ("Lutador3") == "Bario") {
			bario.SetActive (true);
			bario.transform.position = new Vector3 (fighterTres.transform.position.x, fighterTres.transform.position.y, 0);
			ativaosFigheters = ativaosFigheters +1;
		}*/

	}

}
