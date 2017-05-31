using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AtivarElementos : MonoBehaviour {

	public Image fighter, fighterDois, fighterTres;
	public GameObject bromo, zinco, oxigenio, bario;
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
			oxigenio.SetActive (true);
			oxigenio.transform.position = new Vector3 (fighter.transform.position.x, fighter.transform.position.y, 0);
			ativaosFigheters = ativaosFigheters +1;

		}if (PlayerPrefs.GetString ("Lutador2") == "Oxigenio") {
			oxigenio.SetActive (true);
			oxigenio.transform.position = new Vector3 (fighterDois.transform.position.x, fighterDois.transform.position.y, 0);
			ativaosFigheters = ativaosFigheters +1;
		}if (PlayerPrefs.GetString ("Lutador3") == "Oxigenio") {
			oxigenio.SetActive (true);
			oxigenio.transform.position = new Vector3 (fighterTres.transform.position.x, fighterTres.transform.position.y, 0);
			ativaosFigheters = ativaosFigheters +1;
		}

		if (PlayerPrefs.GetString ("Lutador1") == "Bromo") {
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
		}
		if(ativaosFigheters != 3){
			AtivarFighters();
		}
	}

}
