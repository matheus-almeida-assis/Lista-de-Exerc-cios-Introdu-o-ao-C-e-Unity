using UnityEngine;
using System.Collections;

public class Tabuada : MonoBehaviour
{
	public int Numero;
	private int Resultado;

	// Use this for initialization
	void Start ()
	{
		Debug.Log ("Digite um numero e click na tela para começar!\n\n");
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (Input.GetMouseButtonDown (0)) {			
			Debug.Log ("<<<<<<<<<<<Tabuada>>>>>>>>>>>\n\n");
			for (int i = 0; i <= 10; i++) {
				Resultado = Numero * i;
				Debug.Log (Numero.ToString () + " X " + i.ToString () + " = " + Resultado.ToString () + "\n\n");
			}
		}
	}
}
