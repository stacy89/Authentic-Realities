using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class player_controller : MonoBehaviour {
	public float speed;
	public Text countText;
	public Text gameOverText;

	private Rigidbody rb;
	private int count;

	void Start()
	{ 
		rb = GetComponent<Rigidbody>();
		count = 0;
		gameOverText.text = "";
		SetCountText ();

	}

	void FixedUpdate ()
	{
		float moveHorizontal = Input.GetAxis ("Horizontal"); 
		float moveVertical = Input.GetAxis ("Vertical");

		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);
		
		rb.AddForce (movement * speed);
	}
		
	void OnTriggerEnter(Collider other) 
	{
		if (other.gameObject.CompareTag ("Pick Up")) 
		{
			other.gameObject.SetActive (false);
			count = count + 1;
			SetCountText ();
		}
	}

	void SetCountText ()
	{
		countText.text = "Count: " + count.ToString ();
		if (count >= 6) 
		{
			gameOverText.text = "You Win";
		}
	}

}

