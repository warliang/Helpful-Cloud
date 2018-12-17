using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManagerScript : MonoBehaviour {


	public int count;
	public Text countText;

	// Use this for initialization
	void Start () {
		count = 0;
		setText();
	}

	// Update is called once per frame
	public void addPoints(int amt) {
		count = count + amt;
		setText();
	}

	void setText() {
		countText.text = "Score: " + count.ToString();
	}
}
