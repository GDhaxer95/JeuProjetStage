using UnityEngine;
using System.Collections;

public class PlayerCollision : MonoBehaviour {

	void OnCollisionEnter2D (Collision2D col){
		Debug.Log ("We hit something");
		if (col.gameObject.name == "Obstacle"){
			Destroy (this.gameObject);
			Debug.Log ("You lost");
			
		}
	}


}
