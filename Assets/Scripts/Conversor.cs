using UnityEngine;
using System.Collections;

public class Conversor : MonoBehaviour
{
	  
	public double Temperatura;
	public string Medida;
	private double TemperaturaConvertida;

	// Use this for initialization
	void Start ()
	{
		Debug.Log ("Digite a temperatura e escolha a medida \"F\" para Fahrenheit e \"K\" Kelvin\n\n");
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (Input.GetMouseButtonDown (0)) {
			if ((Medida.ToUpper () == "F") || (Medida.ToUpper () == "K")) {
				if (Medida.ToUpper () == "F") { 
					TemperaturaConvertida = ((Temperatura - 32) * 5) / 9;
				} else {
					TemperaturaConvertida = Temperatura - 273.15;
				}
				Debug.Log (string.Concat (TemperaturaConvertida, " Graus Celsius\n\n"));
			} else { 
				Debug.Log ("Medida Invalida escolha a medida novamente \"F\" para Fahrenheit e \"K\" Kelvin\n\n");
			}

		}
	}
}
