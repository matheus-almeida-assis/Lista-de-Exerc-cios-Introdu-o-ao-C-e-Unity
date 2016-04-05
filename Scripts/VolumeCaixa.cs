using UnityEngine;
using System.Collections;
using AssemblyCSharp;

public class VolumeCaixa : MonoBehaviour
{
	public float LadoA;
	public float LadoB;
	public float Altura;
	Caixa C1;
	// Use this for initialization
	void Start ()
	{
		Debug.Log ("Digite as dimenções da caixa e click na tela para começar!\n\n");
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (Input.GetMouseButtonDown (0)) {
			C1 = new Caixa (LadoA, LadoB, Altura);
			Debug.Log (C1.CalcularVolume ().ToString () + "\n\n");
		}	
	}
}
