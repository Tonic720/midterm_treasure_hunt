using UnityEngine;
using System.Collections;

public class PokeBallScript : MonoBehaviour {

    void OnTriggerEnter2D(Collider2D coll) {

        if (coll.isTrigger != true) {

            if (coll.CompareTag("Player")) {
                coll.GetComponent<PlayerHealth>().Hurt(5);
                Destroy(gameObject);
            }


        }

    }
}
