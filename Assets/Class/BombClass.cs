using UnityEngine;
using System.Collections;

public class BombClass : MonoBehaviour {
	private float ySpeed = -4f;
	public GameObject explosionPrefab;
	public PlayerClass player;
	
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
			player.updateScoreBy(+1);
			Destroy(gameObject);
			Instantiate(explosionPrefab, transform.position, Quaternion.identity);
		}
		if (obj.gameObject.name == "ClownFish") {
			//reset fish
			obj.gameObject.transform.rotation = Quaternion.identity;
			obj.gameObject.transform.position = new Vector3(-20f, -1f, 8f);
			player.updateScoreBy(-1);
			Destroy(gameObject);
			Instantiate(explosionPrefab, transform.position, Quaternion.identity);
		}	
	}
}

