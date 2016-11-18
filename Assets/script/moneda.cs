using UnityEngine;
using System.Collections;

public class moneda : MonoBehaviour {
	private Rigidbody2D mipito;

	void Start () {
		Destroy (gameObject, 10);
		mipito = GetComponent <Rigidbody2D> ();
		mipito.AddForce (new Vector2 (Random.Range(-100, 100),100));
	}

	void OnTriggerEnter2D(Collider2D objeto){
		Debug.Log ("Alguien me ha tocado!");
		if (objeto.tag == "Player")
		Destroy (gameObject);
	}
}
