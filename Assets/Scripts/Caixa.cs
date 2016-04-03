using System;

namespace AssemblyCSharp
{
	public class Caixa
	{
		public float LadoA;
		public float LadoB;
		public float Altura;

		public Caixa ()
		{
			
		}

		public float CalcularVolume ()
		{
			return(this.LadoA * this.LadoB * this.Altura);
		}
	}
}

