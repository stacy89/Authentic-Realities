using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class MainPlayerController : MonoBehaviour {
	public float speed;
	public GameObject cube1;
	public GameObject cube2;
	public GameObject cube3;
	public GameObject cube4;
	public GameObject cube5;
	public GameObject cube6;

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
			cube1.SetActive (true);
		}

		if (other.gameObject.CompareTag ("Marriage")) 
		{	
			cube2.SetActive (true);
		}

		if (other.gameObject.CompareTag ("Housing")) 
		{	
			cube3.SetActive (true);
		}

		if (other.gameObject.CompareTag ("Vacation")) 
		{	
			cube4.SetActive (true);
		}

		if (other.gameObject.CompareTag ("Retirement Party")) 
		{	
			cube5.SetActive (true);
		}

		if (other.gameObject.CompareTag ("Retirement")) 
		{	
			cube6.SetActive (true);
		}

//		if (other.gameObject.CompareTag ("")) 
//		{	
//			gameManager.GameOver ();
//			Debug.Log ("hey");
//			//gameManager.GameOver();
//		}

	}

	void OnTriggerExit(Collider other)
	{
		if (other.gameObject.CompareTag ("Starting Stats")) {	
			cube1.SetActive (false);
		}

		if (other.gameObject.CompareTag ("Marriage")) {	
			cube2.SetActive (false);
		}

		if (other.gameObject.CompareTag ("Housing")) {	
			cube3.SetActive (false);
		}

		if (other.gameObject.CompareTag ("Vacation")) {	
			cube4.SetActive (false);
		}

		if (other.gameObject.CompareTag ("Retirement Party")) {	
			cube5.SetActive (false);
		}

		if (other.gameObject.CompareTag ("Retirement")) {	
			cube6.SetActive (false);
		}

	
	}
}

