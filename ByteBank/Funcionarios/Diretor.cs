using System;

namespace ByteBank.Funcionarios
{
	public class Diretor : Funcionario
	{
		public Diretor(string cpf) : base(5000, cpf)
		{
			Console.WriteLine("Criando Diretor");
		}

		public override void AumentarSalario()
		{
			this.Salario *= 1.5;
		}

		public override double GetBonificacao()
		{
			return this.Salario * 0.5;
		}
	}
}
