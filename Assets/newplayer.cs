using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class newplayer : MonoBehaviour {

	private int count;
	public Text countText;
	public Text winText;
	public Text Story1;


	// Use this for initialization
	void Start () {

		count = 0;
		SetCountText ();
		winText.text = "";
		Story1.text = "Follow the pink road and collect the sweet things on purple brick.";

	}

	// Update is called once per frame
	void Update () {

	}

	void OnTriggerEnter ( Collider other ) {


		if (other.gameObject.CompareTag ("Pick Up")) {
			other.gameObject.SetActive (false);
			count = count + 1;
			SetCountText ();
		}

		if (other.gameObject.CompareTag ("Red Pick Up")) {
			other.gameObject.SetActive (false);
			count = count - 1;
			SetCountText ();
		}


		if (other.gameObject.CompareTag ("Land Mine")) {
			SceneManager.LoadScene ("Main Menu");
		}

		if (other.gameObject.CompareTag ("Win")) {
			SceneManager.LoadScene ("Win");
		}

	}

	void SetCountText () {
		countText.text = "Sweet gifts:" + count.ToString ();

		if (count == 1) {
			Story1.text = "Good! Keep doing that and don't pick the things on red brick!";
		}

		if (count >= 4) {
			winText.text = "Great!! You have successfully collected sweet gifts for the children, and you can collect more!";
		}
	}
		
}