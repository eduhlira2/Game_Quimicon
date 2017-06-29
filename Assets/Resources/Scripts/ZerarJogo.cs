using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ZerarJogo : MonoBehaviour {
	public GameObject boro;
	public GameObject selenio;
	public GameObject criptonio;
	public GameObject bromo;
	public GameObject carbono;
	public GameObject cesio;
	public GameObject xenonio;
	public GameObject neon;
	public GameObject litio;
	public GameObject helio;


	// Use this for initialization
	void Start () {
		PlayerPrefs.SetInt ("Boro", 0);
		boro.GetComponent<Image> ().color = Color.black;
		boro.GetComponent<Button> ().enabled = false;

		PlayerPrefs.SetInt ("Selenio", 0);
		selenio.GetComponent<Image> ().color = Color.black;
		selenio.GetComponent<Button> ().enabled = false;

		PlayerPrefs.SetInt ("Criptonio", 0);
		criptonio.GetComponent<Image> ().color = Color.black;
		criptonio.GetComponent<Button> ().enabled = false;

		PlayerPrefs.SetInt ("Bromo", 0);
		bromo.GetComponent<Image> ().color = Color.black;
		bromo.GetComponent<Button> ().enabled = false;

		PlayerPrefs.SetInt ("Carbono", 0);
		carbono.GetComponent<Image> ().color = Color.black;
		carbono.GetComponent<Button> ().enabled = false;

		PlayerPrefs.SetInt ("Cesio", 0);
		cesio.GetComponent<Image> ().color = Color.black;
		cesio.GetComponent<Button> ().enabled = false;

		PlayerPrefs.SetInt ("Xenonio", 0);
		xenonio.GetComponent<Image> ().color = Color.black;
		xenonio.GetComponent<Button> ().enabled = false;

		PlayerPrefs.SetInt ("Neon", 0);
		neon.GetComponent<Image> ().color = Color.black;
		neon.GetComponent<Button> ().enabled = false;

		PlayerPrefs.SetInt ("Litio", 0);
		litio.GetComponent<Image> ().color = Color.black;
		litio.GetComponent<Button> ().enabled = false;

		PlayerPrefs.SetInt ("Helio", 0);
		helio.GetComponent<Image> ().color = Color.black;
		helio.GetComponent<Button> ().enabled = false;


	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
