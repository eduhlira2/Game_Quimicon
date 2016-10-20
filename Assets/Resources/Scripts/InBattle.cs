using UnityEngine;
using System.Collections;
using UnityEngine.UI;



public class InBattle : MonoBehaviour {

	public Image fighter, fighterDois, fighterTres;
	public GameObject lutador, lutadorDois, lutadorTres, controladorBotoes, balaoFala, botaoAtacar;
	public GameObject bromo, zinco, oxigenio;
	public Text ataqueEscolhido, defesaInimigo;
	public Text balaoText, valorInimigo;
	private int atacou, ativaosFigheters;
	public static int contadorminhaVez;



	// Use this for initialization
	void Start () {

		controladorBotoes.SetActive(false);

		fighterTres.sprite = Resources.Load<Sprite> ("Sprites/"+PlayerPrefs.GetString("Lutador3"))as Sprite;
		lutadorTres = Resources.Load<GameObject> ("Prefabs/"+PlayerPrefs.GetString("Lutador3"))as GameObject;

		fighterDois.sprite = Resources.Load<Sprite> ("Sprites/"+PlayerPrefs.GetString("Lutador2"))as Sprite;
		lutadorDois = Resources.Load<GameObject> ("Prefabs/"+PlayerPrefs.GetString("Lutador2"))as GameObject;

		fighter.sprite = Resources.Load<Sprite> ("Sprites/"+PlayerPrefs.GetString("Lutador1"))as Sprite;
		lutador = Resources.Load<GameObject> ("Prefabs/"+PlayerPrefs.GetString("Lutador1"))as GameObject;

		AtivarFighters();
	}
	
	// Update is called once per frame
	void Update () {
		
		
	}

	public void ataqueMassaAtomica(){
		botaoAtacar.SetActive(true);
		atacou = 1;

		balaoText.text = " Use a massa atomica!!"; 
		ataqueEscolhido.text = ((ValoresElementos.massaAtomicaFloat).ToString());
	}

	public void ataqueNumeroAtomico(){
		
		botaoAtacar.SetActive(true);
		atacou = 2;
		balaoText.text = " Use o número Atomico!!"; 
		ataqueEscolhido.text = ((ValoresElementos.numeroAtomicoInt).ToString());
	}

	public void enviarAtaque(){

		controladorBotoes.SetActive (false);
		balaoFala.SetActive (true);

		Invoke ("AtaqueOponente", 1);
	}


	void AtaqueOponente(){
		if (atacou == 1){
			if(Oponente.ataqueDefesa == 1){
				Oponente.massaAtomicaFloat = 15.9f;
				defesaInimigo.text = ((Oponente.massaAtomicaFloat).ToString());
				CheckHit.hitEnemy = float.Parse(defesaInimigo.text );
			}
			if(Oponente.ataqueDefesa == 2){
				Oponente.massaAtomicaFloat = 65.4f;
				defesaInimigo.text = ((Oponente.massaAtomicaFloat).ToString());
				CheckHit.hitEnemy = float.Parse(defesaInimigo.text );
			}
			if(Oponente.ataqueDefesa == 3){
				Oponente.massaAtomicaFloat = 79.9f;
				defesaInimigo.text = ((Oponente.massaAtomicaFloat).ToString());
				CheckHit.hitEnemy = float.Parse(defesaInimigo.text );
			}
		}if(atacou == 2){
			if(Oponente.ataqueDefesa == 1){
				Oponente.numeroAtomicoInt = 8;
				defesaInimigo.text = ((Oponente.numeroAtomicoInt).ToString());
				CheckHit.hitEnemy = float.Parse(defesaInimigo.text );
			}
			if(Oponente.ataqueDefesa == 2){
				Oponente.numeroAtomicoInt = 30;
				defesaInimigo.text = ((Oponente.numeroAtomicoInt).ToString());
				CheckHit.hitEnemy = float.Parse(defesaInimigo.text );
			}
			if(Oponente.ataqueDefesa == 3){
				Oponente.numeroAtomicoInt = 35;
				defesaInimigo.text = ((Oponente.numeroAtomicoInt).ToString());
				CheckHit.hitEnemy = float.Parse(defesaInimigo.text );
			}
		}
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

		if(ativaosFigheters != 3){
			AtivarFighters();
		}
	}


}
