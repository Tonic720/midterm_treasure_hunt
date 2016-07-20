using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class PlayerHealth : MonoBehaviour {
	public int maxHealth = 100;
	public int currentHealth = 0;

	public Text healthText;

	// Use this for initialization
	void Start () {
		// everyone starts at 100% health at the start
		currentHealth = maxHealth;

	}

	void Update(){
		healthText.text = "HP:" + currentHealth;

	}

	// notice we made this a public function; thats so death trigger can use it

	public void Hurt(int damage){

		if (currentHealth <= 0) {
			Destroy (gameObject);
		}
		currentHealth -= damage;
		currentHealth = Mathf.Clamp (currentHealth, 0, maxHealth);
	}
}
