using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class MainPlayerController : MonoBehaviour {
	public float speed;
	public GameObject cube2;
	public GameObject cube3;

	private Rigidbody rb;
	private int count;

	public GameManager gameManager;

	void Start()
	{ 
		rb = GetComponent<Rigidbody>();

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
		if (other.gameObject.CompareTag ("Starting Stats")) 
		{	
			cube2.SetActive (true);
		}

		if (other.gameObject.CompareTag ("Event1")) 
		{	
			cube3.SetActive (true);
		}

		if (other.gameObject.CompareTag ("End Game")) 
		{	
			gameManager.GameOver ();
			//gameManager.GameOver();
		}

	}

	void OnTriggerExit(Collider other)
	{
		if (other.gameObject.CompareTag ("Starting Stats")) {	
			cube2.SetActive (false);
		}
	}
}

