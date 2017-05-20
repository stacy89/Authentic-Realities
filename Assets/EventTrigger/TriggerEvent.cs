using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TriggerEvent : MonoBehaviour {
	public float speed;
	public Text countText;
	public Text gameOverText;

	public Text popUpText;

	private Rigidbody rb;
	private int count;

	void Start()
	{ 
		rb = GetComponent<Rigidbody>();
		count = 0;
		gameOverText.text = "";
		SetCountText ();
		GameObject.Find ("PopUpText").SetActive (false);

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

		if (other.gameObject.CompareTag ("Trigger Box")) {
			GameObject.Find ("PopUpText").SetActive (true);
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

