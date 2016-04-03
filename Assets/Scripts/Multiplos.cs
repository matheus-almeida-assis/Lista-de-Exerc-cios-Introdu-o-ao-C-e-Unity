using UnityEngine;
using System.Collections;

public class Multiplos : MonoBehaviour
{
	public int Numero;
	private int NumDivisores = 0;
	private int Resto;
	private string Divisores;

	// Use this for initialization
	void Start ()
	{
		Debug.Log ("Digite um numero e click na tela para começar!\n\n");
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (Input.GetMouseButtonDown (0)) {
			if ((Numero >= 0) && (Numero <= 1000)) {
				NumDivisores = 1;
				Divisores = Numero.ToString ();
				for (int i = 1; i < Numero; i++) {
					Resto = Numero % (Numero - i);
					if (Resto == 0) {
						NumDivisores++;
						Divisores = Divisores + ", " + (Numero - i).ToString ();
					}
				}
				Debug.Log ("O Numero: " + Numero.ToString () + " tem " + NumDivisores.ToString () + " múltiplos, são eles: " + Divisores + "\n\n"); 
			} else {
				Debug.Log ("Não é possivel calcular os múltiplos deste numero!!\n\n");
			}
		}

	}
}
