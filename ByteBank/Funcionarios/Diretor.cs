namespace ByteBank.Funcionarios
{
	class Diretor : Funcionario
	{
		public override double GetBonificacao()
		{
			return this.Salario + base.GetBonificacao();
		}
	}
}
