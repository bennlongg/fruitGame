using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class floor : MonoBehaviour {

	private int startAmountOfHearts = 5;
	private int currentAmountOfHearts;
	public Image[] hearts;
	// Use this for initialization
	void Start () {
		currentAmountOfHearts = startAmountOfHearts;
		Hearts();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void Hearts() {

		if(currentAmountOfHearts > 0) {
		for(int i = 0; i < startAmountOfHearts; i++) {
			if(currentAmountOfHearts <= i) {
				hearts[i].enabled = false;
			} else {
				hearts[i].enabled = true;
			}
		}
		}
		else {
			SceneManager.LoadScene("Win Screen");
		}
	}

	void OnCollisionEnter2D(Collision2D col) {
		currentAmountOfHearts -= 1;
		Hearts();
		Destroy(col.gameObject);
	}
}
