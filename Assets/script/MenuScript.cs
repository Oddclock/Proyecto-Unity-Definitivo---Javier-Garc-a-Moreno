using UnityEngine;
using System.Collections;
[RequireComponent (typeof(Animator))]

public class MenuScript : MonoBehaviour {

	Animator anim;
	private bool Start_menu = false;

	// Use this for initialization
	void Start () {
		
		anim = GetComponent<Animator> ();
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Escape)) {
			if (Start_menu) {
				Reanudar ();
			} else {
				Pausa ();
		
	}

	public void Pausa(){
		Start_menu = false;
		Time.TimeScale = 1;
		anim.SetBool ("opciones", false);
		anim.SetBool ("pausa", true);
	}

	public void Salir(){
		Application.Quit ();
		Debug.Log ("Saliendo");
	}

	public void Opciones(){
		anim.SetBool ("opciones", true);
		anim.SetBool ("pausa", true);
	}

	public void Reanudar(){
		menu_pausa = true;
		anim.SetBool ("opciones", false);
		anim.SetBool ("pausa", false);

	}
}
