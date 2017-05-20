using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class MainPlayerController : MonoBehaviour {
	public float speed;
	public GameObject cube;

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
		if (other.gameObject.CompareTag ("Trigger Box")) 
		{
			cube.SetActive (true);
		}

		if (other.gameObject.CompareTag ("End Game")) 
		{	
			gameManager.GameOver ();
			//gameManager.GameOver();
		}

	}
}

