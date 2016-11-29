using UnityEngine;
using System.Collections;

public class Autodestruccion : MonoBehaviour {

	ParticleSystem sp;
	// Use this for initialization
	void Start () {
		sp = GetComponent <ParticleSystem> ();
		Destroy (gameObject, sp.duration);

	}
}
