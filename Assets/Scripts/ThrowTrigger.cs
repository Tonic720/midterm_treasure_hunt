using UnityEngine;
using System.Collections;

public class ThrowTrigger : MonoBehaviour {
    public TrainerAI trainerAi;

    public bool isLeft = false;

    void Awake() {
        trainerAi = gameObject.GetComponentInParent<TrainerAI>();

    }

    void OnTriggerStay2D(Collider2D coll) {
        if (coll.CompareTag("Player")) {

            if (isLeft)
            {
                trainerAi.Throw(false);

            }
            else {
                trainerAi.Throw(true);
            }

        }

    }
}
