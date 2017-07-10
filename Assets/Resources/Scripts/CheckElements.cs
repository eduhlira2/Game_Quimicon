using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CheckElements : MonoBehaviour {
	public GameObject helio, litio, neon, selenio, xenonio, criptonio, cesio, carbono, boro, bromo, bario;
	// Use this for initialization
	void Start () {
		if(PlayerPrefs.GetInt("Helio") == 1){
			helio.GetComponent<Image> ().color = Color.white;
			helio.GetComponent<Button> ().enabled = true;
		}
		if(PlayerPrefs.GetInt("Litio") == 1){
			litio.GetComponent<Image> ().color = Color.white;
			litio.GetComponent<Button> ().enabled = true;
		}
		if(PlayerPrefs.GetInt("Neon") == 1){
			neon.GetComponent<Image> ().color = Color.white;
			neon.GetComponent<Button> ().enabled = true;
		}
		if(PlayerPrefs.GetInt("Selenio") == 1){
			selenio.GetComponent<Image> ().color = Color.white;
			selenio.GetComponent<Button> ().enabled = true;
		}
		if(PlayerPrefs.GetInt("Xenonio") == 1){
			xenonio.GetComponent<Image> ().color = Color.white;
			xenonio.GetComponent<Button> ().enabled = true;
		}
		if(PlayerPrefs.GetInt("Criptonio") == 1){
			criptonio.GetComponent<Image> ().color = Color.white;
			criptonio.GetComponent<Button> ().enabled = true;
		}
		if(PlayerPrefs.GetInt("Cesio") == 1){
			cesio.GetComponent<Image> ().color = Color.white;
			cesio.GetComponent<Button> ().enabled = true;
		}
		/*if(PlayerPrefs.GetInt("Carbono") == 1){
			carbono.GetComponent<Image> ().color = Color.white;
			carbono.GetComponent<Button> ().enabled = true;
		}*/
		/*if(PlayerPrefs.GetInt("Boro") == 1){
			boro.GetComponent<Image> ().color = Color.white;
			boro.GetComponent<Button> ().enabled = true;
		}*/
        if (PlayerPrefs.GetInt("Bromo") == 1)
        {
            bromo.GetComponent<Image>().color = Color.white;
            bromo.GetComponent<Button>().enabled = true;
        }
        if (PlayerPrefs.GetInt("Bario") == 1)
        {
            bario.GetComponent<Image>().color = Color.white;
            bario.GetComponent<Button>().enabled = true;
        }
    }

	// Update is called once per frame
	void Update () {
		
	}
}
