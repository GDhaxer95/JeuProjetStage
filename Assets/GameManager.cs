using UnityEngine; //utiliser bibliothèque Unity
using UnityEngine.SceneManagement;//utiliser bibliothèque Unity qui gere les scènes

public class GameManager : MonoBehaviour { //classe GameManager héritière de MonoBehavious

	bool gameHasEnded = false; //instancie variable gameHasEnded de type boolean, en false 

	public float restartDelay = 1f; //variable de type float restardDelay

	public GameObject completeLevelUI; //ici on attribu a un élément de jeu le nom completeLevelUI

	public void CompleteLevel() //fonction CompleteLevel
	{
		Debug.Log ("YOU WON!"); //va afficher you won dans la console
	}

	public void EndGame() //fonction EndGame
	{
		if (gameHasEnded == false) //on check si le jeu en cour à fini
		{
			gameHasEnded = true; //on le met à true
			Debug.Log ("YOU LOST"); //on affiche dans la console you lost
			Invoke("Restart", restartDelay); //on va redemarrer le jeu
		}

	}

	void Restart() { //ici, quand on va recommencer
		SceneManager.LoadScene (SceneManager.GetActiveScene().name); //on va recharger la scène actuelle
	}
}
