using UnityEngine;
using System.Collections;

public class SomaCondicional : MonoBehaviour
{
	public float N1;
	public float N2;
	private float Resultado;

	// Use this for initialization
	void Start ()
	{
		Debug.Log ("Digite dois numeros e click na tela para começar!\n\n");
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (Input.GetMouseButtonDown (0)) {
			Resultado = N1 + N2;
			if (Resultado >= 200) {
				Debug.Log (Resultado.ToString () + "\n\n");
			}
		}
	}
}
