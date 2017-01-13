using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nave : MonoBehaviour { //solo se puede dar impuslo a objetos con rigidbody
	public float fuerza = 10f;
	public float rotacion = 0.5f;
	public ParticleSystem propulsor;
	Rigidbody2D rb;
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.Space)) {
			rb.AddForce (transform.up * fuerza);
			propulsor.Play ();
		}
		if (Input.GetKey (KeyCode.LeftArrow)) {
			rb.AddTorque (rotacion); //torque le da la capacidad de girar al objeto
		}
		if (Input.GetKey (KeyCode.RightArrow)) {
			rb.AddTorque (-rotacion);
		}

		if (Input.GetKeyUp (KeyCode.Space)) {
			propulsor.Stop ();
		}
	}
}
