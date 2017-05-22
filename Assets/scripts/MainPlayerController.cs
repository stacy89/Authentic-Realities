using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class MainPlayerController : MonoBehaviour {
	public float speed;
	public GameObject cube1;
	public GameObject newjobtext;
	public GameObject newhousetext;
	public GameObject vacationtext1;
	public GameObject vacationtext2;
	public GameObject retirement1text;
	public GameObject retirement2text;
	public GameObject retirement3text;
	public Vector3 offset;
	public Vector3 highttext;
	public Vector3 midtext;


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

	void LateUpdate()
	{
		newjobtext.transform.position = (rb.transform.position) + offset;
		newhousetext.transform.position = (rb.transform.position) + offset;
		vacationtext1.transform.position = (rb.transform.position) + midtext;
		vacationtext2.transform.position = (rb.transform.position) + offset;
		retirement1text.transform.position = (rb.transform.position) + highttext;
		retirement2text.transform.position = (rb.transform.position) + midtext;
		retirement3text.transform.position = (rb.transform.position) + offset;


	}
		

	void OnTriggerEnter(Collider other) 
		{



		if (other.gameObject.CompareTag ("Starting Stats")) 
		{	
			cube1.SetActive (true);
		}

		if (other.gameObject.CompareTag ("Marriage")) 
		{	
			newjobtext.SetActive (true);
		}

		if (other.gameObject.CompareTag ("Housing")) 
		{	
			newhousetext.SetActive (true);
		}

		if (other.gameObject.CompareTag ("Vacation")) 
		{	
			vacationtext1.SetActive (true);
			vacationtext2.SetActive (true);
		}



		if (other.gameObject.CompareTag ("Retirement Party")) 
		{	
			retirement1text.SetActive (true);
			retirement2text.SetActive (true);
			retirement3text.SetActive (true);

		}

//		if (other.gameObject.CompareTag ("Retirement")) 
//		{	
////			retirement2text.SetActive (true);
//		}
//


	}

	void OnTriggerExit(Collider other)
	{
		if (other.gameObject.CompareTag ("Starting Stats")) {	
			cube1.SetActive (false);
		}

		if (other.gameObject.CompareTag ("Marriage")) {	
			newjobtext.SetActive (false);
		}

		if (other.gameObject.CompareTag ("Housing")) {	
			newhousetext.SetActive (false);
		}

		if (other.gameObject.CompareTag ("Vacation")) {	
			vacationtext1.SetActive (false);
			vacationtext2.SetActive (false);
		}

		if (other.gameObject.CompareTag ("Retirement Party")) {	
			retirement1text.SetActive (false);


			retirement2text.SetActive (false);
			retirement3text.SetActive (false);
		}

		if (other.gameObject.CompareTag ("Retirement")) {	
			retirement2text.SetActive (false);
		}

		if (other.gameObject.CompareTag ("End Game")) {	
			gameManager.GameOver ();
			Debug.Log ("hey");
			//gameManager.GameOver();
		}

	
	}
		
}

