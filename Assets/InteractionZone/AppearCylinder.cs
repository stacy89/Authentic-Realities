using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppearCylinder : MonoBehaviour {
	public GameObject cylinder;

	void OnTriggerStay(Collider other) 
	{
		if (other.gameObject.CompareTag ("Trigger Box")) 
		{
			cylinder.SetActive (true);
		}
	}

	void OnTriggerExit(Collider other) 
	{
		if (other.gameObject.CompareTag ("Trigger Box")) 
		{
			cylinder.SetActive (false);
		}
	}
}
