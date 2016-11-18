using UnityEngine;
using System.Collections;

public class movimiento_pj : MonoBehaviour {
	public float velocid = 5f;
	public float velocidy = 10;
	public float power = 1f;
	private Animator anim;
	private Rigidbody2D rb;
	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();
		rb = GetComponent<Rigidbody2D> ();
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
		if (Input.GetKeyDown ("up")) {
			rb.velocity = new Vector2 (rb.velocity.x, velocidy);
			transform.localScale = new Vector3 (1, 1, 1);
			anim.SetBool ("jump", true);
		} 
		if (Input.GetKeyUp ("up")) {
			rb.velocity = new Vector2 (rb.velocity.x,rb.velocity.y);
			transform.localScale = new Vector3 (1, 1, 1);
			anim.SetBool ("jump", false);
		} 
	}

}
