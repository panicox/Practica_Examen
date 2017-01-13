using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class robot_script : MonoBehaviour {
	Rigidbody2D rb;
	SpriteRenderer sr;
	public float velocidad = 5; 
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D> ();
		sr = GetComponent<SpriteRenderer> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.LeftArrow)){
			rb.velocity = new Vector2 (-velocidad, 0);
			sr.flipX = true;
	}
		if (Input.GetKey (KeyCode.RightArrow)) {
			rb.velocity = new Vector2 (velocidad, 0);
			sr.flipX = false;
		}
		if (Input.GetKey (KeyCode.DownArrow)) {
			sr.flipY = true;
		}
		if (Input.GetKey (KeyCode.UpArrow)) {
			sr.flipY = false;
		}
	}
}
