using UnityEngine; //utilise la libraire de Unity
using System.Collections; // même chose

public class PlayerCollision : MonoBehaviour { //on instancie une classe nommée PlayerCollision qui hérite de MonoBehaviour


	void OnCollisionEnter2D (Collision2D col){ //quand il y a une collision
		Debug.Log ("We hit something"); //on affiche dans la console qu'on à toucher un truc
		if (col.gameObject.tag == "Obstacle"){ //si le tag de l'objet touché est Obstacle
			FindObjectOfType<GameManager>().EndGame(); //va retourner la foinction EndGame

			
		}
	}


}
