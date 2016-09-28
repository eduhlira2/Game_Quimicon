using UnityEngine;
using System.Collections;
using UnityEngine.UI;



public class InBattle : MonoBehaviour {


	public Image fighter, fighter2, fighter3;
	public GameObject lutador1, lutador2, lutador3;

	//public string nameImage;

	// Use this for initialization
	void Start () {
		
		fighter3.sprite = Resources.Load<Sprite> ("Sprites/"+PlayerPrefs.GetString("Lutador3"))as Sprite;
		lutador3 = Resources.Load<GameObject> ("Prefabs/"+PlayerPrefs.GetString("Lutador3"))as GameObject;
	
		//fighter2.sprite = Resources.Load<Sprite> ("Sprites/"+PlayerPrefs.GetString("Lutador3"))as Sprite;
		//fighter.sprite = Resources.Load<Sprite> ("Sprites/"+PlayerPrefs.GetString("Lutador3"))as Sprite;

		//lutador3 = Resources.Load<GameObject> ("Prefabs/"+nameImage)as GameObject;
	
	}
	
	// Update is called once per frame
	void Update () {
		
		if( Input.GetKeyDown(KeyCode.X)){
			//lutador3.SetActive(true);

			GameObject Fighter=Instantiate(lutador3);
			Fighter.transform.SetParent(gameObject.transform);
		}
	}


}
