﻿using UnityEngine;
using System.Collections;

public class BombClass : MonoBehaviour {
	private float ySpeed = -4f;
	
	// Update is called once per frame
	void Update () {
		transform.Translate( new Vector3(0f, ySpeed*Time.deltaTime, 0f) );
		if (transform.position.y < -11) {
			Destroy(this.gameObject);
		}
	}
	
	void OnTriggerEnter(Collider obj) {
		if (obj.gameObject.name == "Shark") {
			//reset shark
			obj.gameObject.transform.rotation = Quaternion.identity;
			obj.gameObject.transform.position = new Vector3(20f, -3f, 8f);
			Destroy(this.gameObject);
		}
	}
}

