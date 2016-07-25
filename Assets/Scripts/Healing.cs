using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Healing : MonoBehaviour {

	

	void OnTriggerEnter2D(Collider2D coll) {


        if (coll.CompareTag("Player"))
        {
            coll.GetComponent<PlayerHealth>().Hurt(-20);
            Destroy(gameObject);
            //potionText.text = "You Have been healed";
        }
			
		



	}
}
