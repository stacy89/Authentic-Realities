using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportPad : MonoBehaviour {
	public int code;
    public GameObject Movie1;
	float disableTimer=0;

	void Update(){
		if (disableTimer > 0)
			disableTimer -= Time.deltaTime;
	}

	void OnTriggerEnter (Collider collider)
	{
		if (collider.gameObject.name == "player" && disableTimer<=0) {
			foreach (TeleportPad tp in FindObjectsOfType<TeleportPad>()) {
				if (tp.code == code && tp != this) {
					tp.disableTimer = 10;
                    if (Movie1.activeInHierarchy == false)
                    {
                        Movie1.SetActive(true);
                    }
                    else
                    {
                        Movie1.SetActive(false);
                    }                  
                    Vector3 position = tp.gameObject.transform.position;
					collider.gameObject.transform.position = position;
				}
			}
		}
	}
}