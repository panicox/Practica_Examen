using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ladron_script : MonoBehaviour {
	GameObject pringadillo;
	cartera_script cartera_pringao;
	// Use this for initialization
	void Start () {
		pringadillo = GameObject.Find ("pringao");
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Space)) {
			cartera_pringao = pringadillo.GetComponent<cartera_script> ();
			cartera_pringao.donacion (-5);
		}
	}
}
