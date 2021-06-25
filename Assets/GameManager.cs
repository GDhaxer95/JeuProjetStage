using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

	bool gameHasEnded = false;

	public float restartDelay = 1f;

	public GameObject completeLevelUI;

	public void CompleteLevel()
	{
		Debug.Log ("YOU WON!");
	}

	public void EndGame() 
	{
		if (gameHasEnded == false) 
		{
			gameHasEnded = true;
			Debug.Log ("YOU LOST");
			Invoke("Restart", restartDelay);
		}

	}

	void Restart() {
		SceneManager.LoadScene (SceneManager.GetActiveScene().name);
	}
}
