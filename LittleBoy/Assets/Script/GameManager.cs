using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

	public bool GameStart;
	public float TimeGame;
	public float TimeGameStart;

	public GameObject MainMenu;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		TimeGame += Time.deltaTime;

		if (GameStart) {
			TimeGameStart += Time.deltaTime;
		}


	}

	public void Button_Start()
	{
		GameStart = true;
		MainMenu.SetActive (false);
	}

}
