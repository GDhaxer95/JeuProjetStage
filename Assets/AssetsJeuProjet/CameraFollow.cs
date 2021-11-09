using System.Collections; //on va utiliser la librairie Unity
using System.Collections.Generic; //même chose
using UnityEngine; //même chose, il faut absolument mettre celà sinon aucune des fonctions marchera

public class CameraFollow : MonoBehaviour { //on initialise une classe publique nommée CameraFollow, héritière de la classe MonoBehaviour
											//qui est une classe d'unity

	public Transform target; //ici, on va 
	public Vector3 offset; //l'offset de la camera
	public float smoothFactor = 10f; //ici on a le facteur de lissage de la caméra
	Camera cam; //ici on instancie une variable qui va utiliser les données de la caméra

	public void Start(){ //va être exécuté au lancement 
		
		cam = Camera.main; //ici on va stocker dans cam la position de la caméra
	}
	public void Update(){ //c'est une fonction d'unity qui va exécuter le contenu chaque tick

		if (Input.GetKey (KeyCode.KeypadPlus)) //si l'utilisateur appuie sur +
			cam.orthographicSize -= .1f; //on va zoomer la caméra
		if (Input.GetKey (KeyCode.KeypadMinus)) //si il appuie sur -
			cam.orthographicSize += .1f; //on va dézoomer la caméra
	}

	private void FixedUpdate()  //fonction unity qui va être exécutée 2 fois par frame
	{
		Follow (); //on appelle la fonction Follow
	}

	void Follow(){ //ici, on a la définition de la fonction Follow
		
		Vector3 targetPosition = target.position + offset; //on va stocker la position de la cible + l'offset dans targetPosition
		Vector3 smoothedPosition = Vector3.Lerp (transform.position, targetPosition, smoothFactor*Time.fixedDeltaTime); //va permettre a la camera d'être lisse
		transform.position = targetPosition; //ici, on défini la position de la caméra a la position précedente de la cible
	}

	
}
