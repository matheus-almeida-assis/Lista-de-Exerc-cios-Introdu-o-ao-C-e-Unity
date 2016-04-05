using System;

namespace AssemblyCSharp
{
	public class Caixa
	{
		public float LadoA;
		public float LadoB;
		public float Altura;

		public Caixa (float ALadoA, float ALadoB, float AAtuara)
		{
			this.LadoA = ALadoA;
			this.LadoB = ALadoB;
			this.Altura = AAtuara;
		}

		public float CalcularVolume ()
		{
			return(this.LadoA * this.LadoB * this.Altura);
		}
	}
}

