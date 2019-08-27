using System;

namespace ByteBank.Funcionarios
{
	public abstract class Funcionario
	{
		public string Nome { get; set; }
		public string CPF { get; private set; }
		public double Salario { get; protected set; }
		public static int TotalDeFuncionarios { get; private set; }

		public Funcionario(double salario, string cpf)
		{
			this.CPF = cpf;
			this.Salario = salario;
			TotalDeFuncionarios++;
			Console.WriteLine("Criando funcionário");
		}

		public abstract void AumentarSalario();

		public abstract double GetBonificacao();

	}
}
