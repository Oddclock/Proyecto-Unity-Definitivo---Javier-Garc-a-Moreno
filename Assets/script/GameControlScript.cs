using UnityEngine;
using System.Collections;

public class GameControlScript : MonoBehaviour {

	private Vector3 respawn_point;
	public GameObject player;
	public bool esta_vivo = true;
	void Start(){
		respawn_point = player.transform.position;
	}


	public void respawn (){
		player.transform.position = respawn_point;
	}

	public void checkpoint (Vector3 new_point){
		respawn_point = new_point;
	}
}
