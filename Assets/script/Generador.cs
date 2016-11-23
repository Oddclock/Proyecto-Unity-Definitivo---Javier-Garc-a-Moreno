using UnityEngine;
using System.Collections;

public class Generador : MonoBehaviour {
	public GameObject[] Monedas;
	private Transform pos_salida;
	private GameObject moneda_nueva;
	private int numero_moneda = 0;
	public Animator anim;

	void Start (){
		pos_salida = transform.Find ("Posicion_salida").transform;
		Debug.Log ("Cantidad de monedas: " + Monedas.Length);
	}

	void OnCollisionEnter2D (Collision2D col){
		if (col.gameObject.tag == "Player" && moneda_nueva == null) {
			numero_moneda = Random.Range (0, Monedas.Length-1);
			moneda_nueva = (GameObject)Instantiate (Monedas[1],
				pos_salida.position,
				transform.rotation);
		}
	}

	void OnTriggerEnter2D (Collider2D objeto){
		if (objeto.tag == "Player" && moneda_nueva == null) {
			moneda_nueva = (GameObject)Instantiate (Monedas[1],
				transform.position,
				transform.rotation);
		}

	
	}
}
