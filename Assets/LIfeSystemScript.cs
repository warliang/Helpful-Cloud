using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LIfeSystemScript : MonoBehaviour {

	public int currentHealth;
	public GameObject[] healthImage;

	// Use this for initialization
	void Start () {
		currentHealth = 2;
	}

	// Update is called once per frame

	public void loseHealth() {
		if (currentHealth == 0) {
			SceneManager.LoadScene("gameOver");
		}
		else if (currentHealth == 1) {
			currentHealth = currentHealth - 1;
			healthImage[1].SetActive(false);
		}
		else {
			currentHealth = currentHealth - 1;
			healthImage[0].SetActive(false);
		}
	}
}
