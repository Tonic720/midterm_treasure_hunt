using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class PlayerHealth : MonoBehaviour {
	public int maxHealth = 100;
	public int currentHealth = 0;

	public GameObject eevee;
	public GameObject pokeball;

	public Text healthText;
	public bool free;

	// Use this for initialization
	void Start () {
		// everyone starts at 100% health at the start
		currentHealth = maxHealth;
		pokeball.SetActive (false);
		free = true;

	}

	void Update(){
		healthText.text = "HP:" + currentHealth;

	}

	// notice we made this a public function; thats so death trigger can use it

	public void Hurt(int damage){

		if (currentHealth <= 0) {
            SceneManager.LoadScene(2);
        }
		currentHealth -= damage;
		currentHealth = Mathf.Clamp (currentHealth, 0, maxHealth);

		if (currentHealth < 40) {
			eevee.SetActive (false);
			pokeball.SetActive (true);
			free = false;
		}
        if (currentHealth < 35)
        {
            eevee.SetActive(false);
            pokeball.SetActive(true);
            free = false;
        }
        if (currentHealth < 30)
        {
            eevee.SetActive(false);
            pokeball.SetActive(true);
            free = false;
        }
        if (currentHealth < 25)
        {
            eevee.SetActive(false);
            pokeball.SetActive(true);
            free = false;
        }
        if (currentHealth < 20)
        {
            eevee.SetActive(false);
            pokeball.SetActive(true);
            free = false;
        }
        if (currentHealth < 15)
        {
            eevee.SetActive(false);
            pokeball.SetActive(true);
            free = false;
        }

        if (currentHealth < 10)
        {
            eevee.SetActive(false);
            pokeball.SetActive(true);
            free = false;
        }
        if (currentHealth < 5)
        {
            eevee.SetActive(false);
            pokeball.SetActive(true);
            free = false;
        }
    }
}
