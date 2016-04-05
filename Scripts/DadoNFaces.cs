using UnityEngine;
using System.Collections;

public class DadoNFaces : MonoBehaviour
{
	public int NumeroFaces;
	private int Resultado;
	// Use this for initialization
	void Start ()
	{
		Debug.Log ("Digite um numero de faces para o dado e click na tela para começar!\n\n");
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (Input.GetMouseButtonDown (0)) {
			Resultado = Random.Range (1, NumeroFaces);
			Debug.Log (Resultado.ToString () + "\n\n");
		}
	}
}
