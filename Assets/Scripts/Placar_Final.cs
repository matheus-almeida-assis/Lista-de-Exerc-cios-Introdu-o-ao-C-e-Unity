using UnityEngine;
using System.Collections;

public class Placar_Final : MonoBehaviour
{
	public int PlacarTimeA;
	public int PlacarTimeB;
	private string Resultado;

	// Use this for initialization
	void Start ()
	{
		Debug.Log ("Digite o placar e click na tela para começar!\n\n");
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (Input.GetMouseButtonDown (0)) {
			if (PlacarTimeA > PlacarTimeB) {
				Resultado = "Vitória Time A!!!";
			} else if (PlacarTimeA < PlacarTimeB) {
				Resultado = "Vitória Time B!!!";
			} else if (PlacarTimeA == PlacarTimeB) {
				Resultado = "Um Empate";
				if (PlacarTimeA > 3) {
					Resultado = Resultado + " Emocionante!!!";
				}
			}
			Debug.Log (Resultado + "\n\n");
		}
	}
}
