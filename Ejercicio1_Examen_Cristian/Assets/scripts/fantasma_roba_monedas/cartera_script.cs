using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class cartera_script : MonoBehaviour {

	int monedas = 100;
	public Text texto_monedas;

	void Update(){
		texto_monedas.text = monedas.ToString ();
	}
	public void donacion(int dinero){
		//"if(dinero > 0){" para asegurarnos de que no puede robarle dinero, solo darle
			monedas += dinero;
	}
}