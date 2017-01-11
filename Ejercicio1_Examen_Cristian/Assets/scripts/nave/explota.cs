using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class explota : MonoBehaviour {
	public GameObject plataforma;
	public GameObject explosion;
	public Animator panel_animator; 
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter2D(Collision2D col){
		panel_animator.SetBool ("visible", true); //"visible" es el nombre del bool (true o false) de la animacion
		Instantiate (explosion, transform.position,transform.rotation); //todo lo que está en minúsculas es sobre uno mismo. Instantiate llama a la explosion y hay que darle 2 vectores
		Destroy (gameObject);
		Destroy (plataforma);
	}
}
