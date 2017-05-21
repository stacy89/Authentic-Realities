using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportPad : MonoBehaviour {
	public int code;
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
					tp.disableTimer = 5;
					Vector3 position = tp.gameObject.transform.position;
					collider.gameObject.transform.position = position;
				}
			}
		}
	}
}