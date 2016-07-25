using UnityEngine;
using System.Collections;

public class TrainerAI : MonoBehaviour {

    //Float
    public float distance;
    public float visonRange;
    public float throwInterval;
    public float pokeballSpeed = 200f;
    public float pokeballTimer;

    //Bools
    public bool playerSeen = false;
   

    //References
    public GameObject pokeball;
    public Transform target;
    public Transform throwPointLeft,throwPointRight;

    void Update() {
        RangeCheck();

        if (target.transform.position.x > transform.position.x) {
            
            transform.localScale = new Vector3(1f, 1f, 1f);

        }
        if (target.transform.position.x < transform.position.x)
        {
           
           transform.localScale = new Vector3(-1f, 1f, 1f);
            

        }
    }

    void RangeCheck() {
        distance = Vector3.Distance(transform.position,target.transform.position);

        if (distance < visonRange) {
            playerSeen = true;
           

        }
        if (distance > visonRange) {
            playerSeen = false;
        }


    }
    public void Throw(bool throwRight) {
        pokeballTimer += Time.deltaTime;

        if (pokeballTimer >= throwInterval) {
            Vector2 direction = target.transform.position - transform.position;
            direction.Normalize();

        
        if (!throwRight) {
            GameObject pokeballClone;
            pokeballClone = Instantiate(pokeball,throwPointLeft.transform.position,throwPointLeft.transform.rotation) as GameObject;
                pokeballClone.GetComponent<Rigidbody2D>().velocity = direction * pokeballSpeed;

                pokeballTimer = 0;
         }
            if (throwRight) {
                GameObject pokeballClone;
                pokeballClone = Instantiate(pokeball, throwPointRight.transform.position, throwPointRight.transform.rotation) as GameObject;
                pokeballClone.GetComponent<Rigidbody2D>().velocity = direction * pokeballSpeed;

                pokeballTimer = 0;
            }
          }
    }
    
}
