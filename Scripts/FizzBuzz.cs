using UnityEngine;
using System.Collections;

public class FizzBuzz : MonoBehaviour
{
	private int Resto;
	private string Resultado;
	// Use this for initialization
	void Start ()
	{
		Debug.Log ("Click na tela para começar!\n\n");
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (Input.GetMouseButtonDown (0)) {			
			Debug.Log ("<<<<<<<<<<<Fizz Buzz>>>>>>>>>>>\n\n");
			for (int i = 0; i <= 1000; i++) {
				Resultado = "";
				Resto = i % 3;
				if (Resto == 0) {
					Resultado = "fizz ";
				}
				Resto = i % 5;
				if (Resto == 0) {
					Resultado = Resultado + "buzz";
				}
				Debug.Log (i.ToString () + ":" + Resultado + "\n\n");
			}
		}
	}
}
