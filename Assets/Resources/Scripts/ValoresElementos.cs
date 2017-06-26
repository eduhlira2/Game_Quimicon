using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ValoresElementos : MonoBehaviour {

	public Text massaAtomica, numeroAtomico, ataqueEscolhido, nomePlayer;
	public static float massaAtomicaFloat;
	public static int numeroAtomicoInt, personagemSelecionado;
	public string nomeElemento;
	public GameObject controladorBotoes, botaoAtacar, massaBotao, numeroBotao, controleAnimacao;
	public Image jogador;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void MudarValores(string ToSave){
		
		controleAnimacao.GetComponent<Animator>().Play("EscolhaElemento");
		nomeElemento = ToSave;
		ataqueEscolhido.text = "0";
		botaoAtacar.SetActive(false);
		if (LutaControler.enemyAtaqueLimite == 0) {
			massaBotao.SetActive (false);
			numeroBotao.SetActive (true);
		} if(LutaControler.enemyAtaqueLimite == 1){
			massaBotao.SetActive (true);
			numeroBotao.SetActive (false);
		} if(LutaControler.enemyAtaqueLimite == 2){
			massaBotao.SetActive (true);
			numeroBotao.SetActive (true);
		}


		if (PlayerPrefs.GetString ("Lutador1") == "Oxigenio" && nomeElemento == "Oxigenio") {
			massaAtomicaFloat = 15.9f; numeroAtomicoInt = 8;
			massaAtomica.text = ((massaAtomicaFloat).ToString());
			numeroAtomico.text = ((numeroAtomicoInt).ToString());
			jogador.sprite = Resources.Load<Sprite> ("Sprites/"+"Oxigenio")as Sprite;
			controladorBotoes.SetActive(true);
			nomePlayer.text = "Oxigenio";
		}if (PlayerPrefs.GetString ("Lutador2") == "Oxigenio" && nomeElemento == "Oxigenio") {
			massaAtomicaFloat = 15.9f; numeroAtomicoInt = 8;
			massaAtomica.text = ((massaAtomicaFloat).ToString());
			numeroAtomico.text = ((numeroAtomicoInt).ToString());
			controladorBotoes.SetActive(true);
			nomePlayer.text = "Oxigenio";
			jogador.sprite = Resources.Load<Sprite> ("Sprites/"+"Oxigenio")as Sprite;
		}if (PlayerPrefs.GetString ("Lutador3") == "Oxigenio" && nomeElemento == "Oxigenio") {
			massaAtomicaFloat = 15.9f; numeroAtomicoInt = 8;
			massaAtomica.text = ((massaAtomicaFloat).ToString());
			numeroAtomico.text = ((numeroAtomicoInt).ToString());
			jogador.sprite = Resources.Load<Sprite> ("Sprites/"+"Oxigenio")as Sprite;
			controladorBotoes.SetActive(true);
			nomePlayer.text = "Oxigenio";
		}

		if (PlayerPrefs.GetString ("Lutador1") == "Zinco" && nomeElemento == "Zinco") {
			massaAtomicaFloat = 65.4f; numeroAtomicoInt = 30;
			massaAtomica.text = ((massaAtomicaFloat).ToString());
			numeroAtomico.text = ((numeroAtomicoInt).ToString());
			jogador.sprite = Resources.Load<Sprite> ("Sprites/"+"Zinco")as Sprite;
			controladorBotoes.SetActive(true);
			nomePlayer.text = "Zinco";
		}if (PlayerPrefs.GetString ("Lutador2") == "Zinco" && nomeElemento == "Zinco") {
			massaAtomicaFloat = 65.4f; numeroAtomicoInt = 30;
			massaAtomica.text = ((massaAtomicaFloat).ToString());
			numeroAtomico.text = ((numeroAtomicoInt).ToString());
			jogador.sprite = Resources.Load<Sprite> ("Sprites/"+"Zinco")as Sprite;
			controladorBotoes.SetActive(true);
			nomePlayer.text = "Zinco";
		}if (PlayerPrefs.GetString ("Lutador3") == "Zinco" && nomeElemento == "Zinco") {
			massaAtomicaFloat = 65.4f; numeroAtomicoInt = 30;
			massaAtomica.text = ((massaAtomicaFloat).ToString());
			numeroAtomico.text = ((numeroAtomicoInt).ToString());
			jogador.sprite = Resources.Load<Sprite> ("Sprites/"+"Zinco")as Sprite;
			controladorBotoes.SetActive(true);
			nomePlayer.text = "Zinco";
		}

		if (PlayerPrefs.GetString ("Lutador1") == "Bromo" && nomeElemento == "Bromo") {
			massaAtomicaFloat = 79.9f; numeroAtomicoInt = 35;
			massaAtomica.text = ((massaAtomicaFloat).ToString());
			numeroAtomico.text = ((numeroAtomicoInt).ToString());
			jogador.sprite = Resources.Load<Sprite> ("Sprites/"+"Bromo")as Sprite;
			controladorBotoes.SetActive(true);
			nomePlayer.text = "Bromo";
		}if (PlayerPrefs.GetString ("Lutador2") == "Bromo" && nomeElemento == "Bromo") {
			massaAtomicaFloat = 79.9f; numeroAtomicoInt = 35;
			massaAtomica.text = ((massaAtomicaFloat).ToString());
			numeroAtomico.text = ((numeroAtomicoInt).ToString());
			jogador.sprite = Resources.Load<Sprite> ("Sprites/"+"Bromo")as Sprite;
			controladorBotoes.SetActive(true);
			nomePlayer.text = "Bromo";
		}if (PlayerPrefs.GetString ("Lutador3") == "Bromo" && nomeElemento == "Bromo") {
			massaAtomicaFloat = 79.9f; numeroAtomicoInt = 35;
			massaAtomica.text = ((massaAtomicaFloat).ToString());
			numeroAtomico.text = ((numeroAtomicoInt).ToString());
			jogador.sprite = Resources.Load<Sprite> ("Sprites/"+"Bromo")as Sprite;
			controladorBotoes.SetActive(true);
			nomePlayer.text = "Bromo";
		}
		if (PlayerPrefs.GetString ("Lutador1") == "Bario" && nomeElemento == "Bario") {
			massaAtomicaFloat = 137.3f; numeroAtomicoInt = 56;
			massaAtomica.text = ((massaAtomicaFloat).ToString());
			numeroAtomico.text = ((numeroAtomicoInt).ToString());
			jogador.sprite = Resources.Load<Sprite> ("Sprites/"+"Bario")as Sprite;
			controladorBotoes.SetActive(true);
			nomePlayer.text = "Bario";
		}if (PlayerPrefs.GetString ("Lutador2") == "Bario" && nomeElemento == "Bario") {
			massaAtomicaFloat = 137.3f; numeroAtomicoInt = 56;
			massaAtomica.text = ((massaAtomicaFloat).ToString());
			numeroAtomico.text = ((numeroAtomicoInt).ToString());
			jogador.sprite = Resources.Load<Sprite> ("Sprites/"+"Bario")as Sprite;
			controladorBotoes.SetActive(true);
			nomePlayer.text = "Bario";
		}if (PlayerPrefs.GetString ("Lutador3") == "Bario" && nomeElemento == "Bario") {
			massaAtomicaFloat = 137.3f; numeroAtomicoInt = 56;
			massaAtomica.text = ((massaAtomicaFloat).ToString());
			numeroAtomico.text = ((numeroAtomicoInt).ToString());
			jogador.sprite = Resources.Load<Sprite> ("Sprites/"+"Bario")as Sprite;
			controladorBotoes.SetActive(true);
			nomePlayer.text = "Bario";
		}
	}
}
