using UnityEngine;
using System.Collections;

public class player1_controles : MonoBehaviour {

	Animator anim;
	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.A)) {
			anim.SetFloat ("velocidad", 1f);
		}
		if (Input.GetKeyUp (KeyCode.A)) {
			anim.SetFloat ("velocidad", 0f);
		}
		if (Input.GetKeyDown (KeyCode.Space)) {
			anim.SetBool ("jump", true);
		}
		if (Input.GetKeyUp (KeyCode.Space)) {
			anim.SetBool ("jump", false);
		}
	}
}
