using UnityEngine;
using System.Collections;

public class Checkpoint : MonoBehaviour {

	private GameControlScript gcs;
	public Sprite banderaOn;
	private bool on = false;
	// Use this for initialization
	void Start () {
		gcs = GameObject.Find ("GameControl").GetComponent<GameControlScript> ();
	}

	void OnTriggerEnter2D (Collider2D objeto){
		if (objeto.tag == "Player" && !on) {
			GetComponent <SpriteRenderer> ().sprite = banderaOn;
			gcs.checkpoint (transform.position);
			on = true;
		}
	}
}