using UnityEngine;
using System.Collections;

public class Movimiento_player : MonoBehaviour {
	public float velocid = 5f;
	public float velocidy = 5;
	public float power = 1f;
	public bool colision_suelo = false;
	public GameObject particulas_muerte;
	private Animator anim;
	private Rigidbody2D rb;
	private GameControlScript gcs;

	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();
		rb = GetComponent<Rigidbody2D> ();
		gcs = GameObject.Find ("GameControl").GetComponent<GameControlScript>();

	}
		
	// Update is called once per frame
	void Update () {

		if (Input.GetKey ("right")) {
			rb.velocity = new Vector2 (velocid, rb.velocity.y);
			transform.localScale = new Vector3 (1, 1, 1);
			anim.SetFloat ("velocidad", Mathf.Abs(rb.velocity.x));
		} 
		if (Input.GetKeyUp ("right")) {
			rb.velocity = new Vector2 (0, rb.velocity.y);
			transform.localScale = new Vector3 (1, 1, 1);
			anim.SetFloat ("velocidad", Mathf.Abs(rb.velocity.x));
		
		}
		else if (Input.GetKey ("left")) {
			rb.velocity = new Vector2 (-velocid, rb.velocity.y);
			transform.localScale = new Vector3 (-1, 1, 1);
			anim.SetFloat ("velocidad", Mathf.Abs(rb.velocity.x));
		} 
		else if (Input.GetKeyUp ("left")) {
			rb.velocity = new Vector2 (0, rb.velocity.y);
			transform.localScale = new Vector3 (-1, 1, 1);
			anim.SetFloat ("velocidad", Mathf.Abs(rb.velocity.x));

		}
		if (Input.GetKeyDown ("up") && (colision_suelo) ) {
			rb.velocity = new Vector2 (rb.velocity.x, velocidy);
			transform.localScale = new Vector3 (1, 1, 1);
			anim.SetBool ("jump", true);
		} 
		if (Input.GetKeyUp ("up")) {
			rb.velocity = new Vector2 (rb.velocity.x,rb.velocity.y);
			transform.localScale = new Vector3 (1, 1, 1);

		} 
	}
	void OnTriggerEnter2D (Collider2D objeto){
		if (objeto.tag == "Suelo") {
			colision_suelo = true;
			Debug.Log ("Toco suelo");
			anim.SetBool ("jump", false);
		} 
	}
	void OnTriggerExit2D (Collider2D objeto){
		if (objeto.tag == "Suelo") {
			colision_suelo = false;
			Debug.Log ("No toco suelo");

		} 
	}

	void OnCollisionEnter2D (Collision2D col){
		if (col.gameObject.tag == "Muerte"){
			//gcs.respawn ();
			Instantiate(particulas_muerte, transform.position, transform.rotation);
	}

	}
}