using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Security.Cryptography.X509Certificates;
using System;

public class Treasure : MonoBehaviour {

	bool didPlayerWin = false;
	public Text gameText;
	public Transform player;
	public Transform maletrainer;
	public Transform zubat;
	public Transform femaletrainer;
	public Transform doduo;
	public Transform lake;
	public Transform charmander;
    public Transform bulbasuar;
    public Transform pidgey;
    public Transform rattata;
    public Transform poliwag;

    void Update () {
		if ((player.position - maletrainer.transform.position).magnitude < 5f) {
			gameText.text = "Eevee: Oh no, there's a trainer! He must be here to catch mother! I'd better go the other way!";
		} else if ((player.position - zubat.transform.position).magnitude < 1f) {
			gameText.text = "Zubat: I just want to befriend humans but all they do is run away from me ... oh Vaporeon? She's hiding north of here.";
		} else if ((player.position - femaletrainer.transform.position).magnitude < 5f) {
			gameText.text = "Eevee: Ahh another one of them! They are everywhere! I have to go the other way!";
		} else if ((player.position - doduo.transform.position).magnitude < 1f) {
			gameText.text = "Doduo: Why doesn't anybody want to catch me? Vaporeon? Haven't seen her anywhere near here.";
		} else if ((player.position - lake.transform.position).magnitude < 5f) {
			gameText.text = "Eevee: Water! Mother likes water. She must be around here somewhere!";
		} else if ((player.position - charmander.transform.position).magnitude < 1f) {
			gameText.text = "Charmander: I'm staying far away from the hoard of trainers and you should too. Vaporeon is that way!";
		}
          else if ((player.position - bulbasuar.transform.position).magnitude < 1f)
        {
            gameText.text = "Bulbasuar: Hey if you need health i saw a potion over there";
        }
        else if ((player.position - pidgey.transform.position).magnitude < 1f)
        {
            gameText.text = "Pidgey: You're looking for Vaporeon check the lake it's north of here";
        }
        else if ((player.position - rattata.transform.position).magnitude < 1f)
        {
            gameText.text = "Rattata: I saw Vaporeon at the top of the lake";
        }
        else if ((player.position - poliwag.transform.position).magnitude < 1f)
        {
            gameText.text = "Poliwag: Vaporeon is on the other side of the lake";
        }
        else if ((player.position - transform.position).magnitude < 1f) {
			gameText.text = "Press [space] to reunite with your mother.";
            if (Input.GetKeyDown(KeyCode.Space))
            {
                SceneManager.LoadScene(3);
            }
		} else {
			gameText.text = "";
		}

	}
}