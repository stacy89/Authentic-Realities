using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {
	
	public Text resetText; 
	private bool reset; 
	static bool gameOver; 

	void Start ()
	{	
		gameOver = false;
		reset = false;
		//resetText.text = "";
	}

	void Update () 
	{
		if (reset) 
		{
			if (Input.GetKeyDown (KeyCode.R))
				{
					Application.LoadLevel (Application.loadedLevel);
				}
		}

	}

	public void GameOver ()
	{
			//resetText.text = "press r for restart";
			//reset = true;
//		gameOver = true;
//		resetText.text = "press r for restart";
//		return gameOver;
		Debug.Log("Halksjdblakjbf");
	}

}
