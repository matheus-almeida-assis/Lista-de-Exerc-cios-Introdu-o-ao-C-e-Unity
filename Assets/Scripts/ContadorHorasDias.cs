using UnityEngine;
using System.Collections;

public class ContadorHorasDias : MonoBehaviour
{

	private int Segundos;
	private int Horas;
	private int Dias;
	// Use this for initialization
	void Start ()
	{
	
	}
	
	// Update is called once per frame
	void Update ()
	{
		Segundos++;
		if (Segundos == 10) {
			Segundos = 0;
			Horas++;
		}
		if (Horas == 24) {
			Horas = 0;
			Dias++;
			Debug.Log (Dias.ToString () + " Dias, Click na tela para começar novamente!!!\n\n");
		}
		if (Input.GetMouseButtonDown (0)) {
			Segundos = 0;
			Horas = 0;
			Dias = 0;
		}
	}
}
