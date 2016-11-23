using UnityEngine;
using System.Collections;
[RequireComponent (typeof(Animator))]

public class MenuScript : MonoBehaviour {

	Animator anim;
	private bool menu_pausa = false;

	// Use this for initialization
	void Start () {

		anim = GetComponent<Animator> ();

	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Escape)){
			if (menu_pausa) {
				Reanudar ();
			} else {
				Pausa ();
			}
		}

		public void Pausa(){
			menu_pausa = false;
			Time.TimeScale = 1;
			anim.SetBool ("Opciones", false);
			anim.SetBool ("Pausa", true);
		}

		public void Salir(){
			Application.Quit ();
			Debug.Log ("Saliendo");
		}

		public void Opciones(){
			anim.SetBool ("Opciones", true);
			anim.SetBool ("Pausa", true);
		}

		public void Reanudar(){
			menu_pausa = true;
			anim.SetBool ("Opciones", false);
			anim.SetBool ("Pausa", false);

		}
	}
