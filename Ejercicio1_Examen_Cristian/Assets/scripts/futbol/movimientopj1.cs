using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimientopj1 : MonoBehaviour {
    Rigidbody2D rb;
    // Use this for initialization
    void Start() {
		rb = GetComponent<Rigidbody2D> ();
    }

    // Update is called once per frame
    void Update() {
        if (Input.GetKeyDown(KeyCode.UpArrow)){
			rb.velocity = new Vector2 (0,10);
        }
		if (Input.GetKeyDown(KeyCode.DownArrow)){
			rb.velocity = new Vector2 (0,-10);
		}
		if (Input.GetKeyDown(KeyCode.LeftArrow)){
			rb.velocity = new Vector2 (-10,0);
		}
		if (Input.GetKeyDown(KeyCode.RightArrow)){
			rb.velocity = new Vector2 (10,0);
		}
//------------------------------------GETKEYUP------------------------------------------
		if (Input.GetKeyUp(KeyCode.UpArrow)){
			rb.velocity = new Vector2 (0,0);
		}
		if (Input.GetKeyUp(KeyCode.DownArrow)){
			rb.velocity = new Vector2 (0,0);
		}
		if (Input.GetKeyUp(KeyCode.LeftArrow)){
			rb.velocity = new Vector2 (0,0);
		}
		if (Input.GetKeyUp(KeyCode.RightArrow)){
			rb.velocity = new Vector2 (0,0);
		}
    }
}
