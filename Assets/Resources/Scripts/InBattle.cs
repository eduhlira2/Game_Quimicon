using UnityEngine;
using System.Collections;
using UnityEngine.UI;



public class InBattle : MonoBehaviour {

	public Image fighter, fighterDois, fighterTres;
	public GameObject lutador, lutadorDois, lutadorTres;
	public GameObject bromo, zinco, oxigenio;
	public Text ataqueEscolhido;
	private int atacou;

	// Use this for initialization
	void Start () {
		fighterTres.sprite = Resources.Load<Sprite> ("Sprites/"+PlayerPrefs.GetString("Lutador3"))as Sprite;
		lutadorTres = Resources.Load<GameObject> ("Prefabs/"+PlayerPrefs.GetString("Lutador3"))as GameObject;

		fighterDois.sprite = Resources.Load<Sprite> ("Sprites/"+PlayerPrefs.GetString("Lutador2"))as Sprite;
		lutadorDois = Resources.Load<GameObject> ("Prefabs/"+PlayerPrefs.GetString("Lutador2"))as GameObject;

		fighter.sprite = Resources.Load<Sprite> ("Sprites/"+PlayerPrefs.GetString("Lutador1"))as Sprite;
		lutador = Resources.Load<GameObject> ("Prefabs/"+PlayerPrefs.GetString("Lutador1"))as GameObject;
	}
	
	// Update is called once per frame
	void Update () {
		AtivarFighters();

	}

	public void ataqueMassaAtomica(){
		atacou = 1;base nm
		ataqueEscolhido.text = ((ValoresElementos.massaAtomicaFloat).ToString());
	}

	public void ataqueNumeroAtomico(){
		atacou = 2;
		ataqueEscolhido.text = ((ValoresElementos.numeroAtomicoInt).ToString());
	}

	public void enviarAtaque(){
		if (atacou == 1){
			
		}if(atacou == 2){
			
		}
	}

	void AtivarFighters(){

		if (PlayerPrefs.GetString ("Lutador1") == "Oxigenio") {
			oxigenio.SetActive (true);
			oxigenio.transform.position = new Vector3 (fighter.transform.position.x, fighter.transform.position.y, 0);
		
		}if (PlayerPrefs.GetString ("Lutador2") == "Oxigenio") {
			oxigenio.SetActive (true);
			oxigenio.transform.position = new Vector3 (fighterDois.transform.position.x, fighterDois.transform.position.y, 0);

		}if (PlayerPrefs.GetString ("Lutador3") == "Oxigenio") {
			oxigenio.SetActive (true);
			oxigenio.transform.position = new Vector3 (fighterTres.transform.position.x, fighterTres.transform.position.y, 0);

		}

		if (PlayerPrefs.GetString ("Lutador1") == "Bromo") {
			bromo.SetActive (true);
			bromo.transform.position = new Vector3 (fighter.transform.position.x, fighter.transform.position.y, 0);
		}if (PlayerPrefs.GetString ("Lutador2") == "Bromo") {
			bromo.SetActive (true);
			bromo.transform.position = new Vector3 (fighterDois.transform.position.x, fighterDois.transform.position.y, 0);	
		}if (PlayerPrefs.GetString ("Lutador3") == "Bromo") {
			bromo.SetActive (true);
			bromo.transform.position = new Vector3 (fighterTres.transform.position.x, fighterTres.transform.position.y, 0);

	  }
		if (PlayerPrefs.GetString ("Lutador1") == "Zinco") {
			zinco.SetActive (true);
			zinco.transform.position = new Vector3 (fighter.transform.position.x, fighter.transform.position.y, 0);
		}if (PlayerPrefs.GetString ("Lutador2") == "Zinco") {
			zinco.SetActive (true);
			zinco.transform.position = new Vector3 (fighterDois.transform.position.x, fighterDois.transform.position.y, 0);	
		}if (PlayerPrefs.GetString ("Lutador3") == "Zinco") {
			zinco.SetActive (true);
			zinco.transform.position = new Vector3 (fighterTres.transform.position.x, fighterTres.transform.position.y, 0);
		}


	}
}
