using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class player1A : MonoBehaviour {

	private int count;
	public Text countText;
	public Text winText;
	public Text Story1;


	// Use this for initialization
	void Start () {

		count = 0;
		SetCountText ();
		winText.text = "You Win!!!";
		Story1.text = "Follow the red brick road and collect the coins";

	}

	// Update is called once per frame
	void Update () {

	}

	void OnTriggerEnter ( Collider other ) {


		if (other.gameObject.CompareTag ("Pick Up")) {
			other.gameObject.SetActive (false);
			count = count + 5;
			SetCountText ();
		}

		if (other.gameObject.CompareTag ("Red Pick Up")) {
			other.gameObject.SetActive (false);
			count = count - 5;
			SetCountText ();
		}


		if (other.gameObject.CompareTag ("Land Mine")) {
			SceneManager.LoadScene ("Main Menu");
		}

	}

	void SetCountText () {
		countText.text = "Coins: " + count.ToString ();

		if (count == 5) {
			Story1.text = "";
		}

		if (count >= 30) {
			winText.text = "Awesome Babe. You Win!";
		}
	}

}