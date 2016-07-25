using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class PlayerPhysicsMove : MonoBehaviour {

	public float moveSpeed;
	PlayerHealth hp;
    int chance;
    bool caught = false;





    void Start(){

		hp = gameObject.GetComponent<PlayerHealth> ();
	}

	// Update is where rendering and input update
	// FixedUpdate is called once per physics frame
	void FixedUpdate () {
        

        

        if (hp.free == true) {
			//hp.currentHealth = 10;
			// reset velocity every frame
			GetComponent<Rigidbody2D> ().velocity = new Vector2 (0f, 0f);

			// press W to apply upward force
			if (Input.GetKey (KeyCode.UpArrow)) {
				GetComponent<Rigidbody2D> ().velocity += new Vector2 (0f, moveSpeed) * Time.deltaTime;
			}

			if (Input.GetKey (KeyCode.LeftArrow)) {
				GetComponent<Rigidbody2D> ().velocity += new Vector2 (-moveSpeed, 0f) * Time.deltaTime;
			}

			if (Input.GetKey (KeyCode.RightArrow)) {
				GetComponent<Rigidbody2D> ().velocity += new Vector2 (moveSpeed, 0f) * Time.deltaTime;
			}

			if (Input.GetKey (KeyCode.DownArrow)) {
				GetComponent<Rigidbody2D> ().velocity += new Vector2 (0f, -moveSpeed) * Time.deltaTime;
			}

		}
        if(hp.free == false && caught == false){
            GetComponent<Rigidbody2D>().velocity = new Vector2(0f, 0f);

            if (Input.GetKeyDown (KeyCode.Space)) {
                chance = Random.Range(0, 6);
                Debug.Log(chance);
                if (chance < 1) {
                    hp.free = false;
                    caught = true;
                    SceneManager.LoadScene(2);


                }
                if (chance > 1) {
                    hp.free = true;
                    hp.eevee.SetActive(true);
                    hp.pokeball.SetActive(false);

                }
			}
			
		}
	}
}
