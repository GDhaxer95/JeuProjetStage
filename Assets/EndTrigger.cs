using UnityEngine; //utilise la librairie unity

public class EndTrigger : MonoBehaviour { //instancie la classe EndTrigger héritière de MonoBehaviour

	public GameManager gameManager; //on instancie une variable dans la classe GameManager

	void OnTriggerEnter2D () { //fonction unity qui va check si on touche un élement qui est un trigger 

		gameManager.CompleteLevel (); //si on active le trigger, on apelle la fonction CompleteLevel

	}

}
