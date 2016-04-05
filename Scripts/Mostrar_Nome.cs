using UnityEngine;
using System.Collections;

public class Mostrar_Nome : MonoBehaviour
{
	public string Nome;
	public string Sobrenome;
	public bool MostrarNome;
	// Use this for initialization
	void Start ()
	{
		Debug.Log ("Digite o seu Nome, Sobrenome, escolha se deseja ou não mostrar o nome e click na tela para começar!\n\n");
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (Input.GetMouseButtonDown (0)) {
			if (MostrarNome) {
				Debug.Log (Nome + " " + Sobrenome + "\n\n");
			} else {
				Debug.Log (Sobrenome + "\n\n");
			}
		}
	}
}
