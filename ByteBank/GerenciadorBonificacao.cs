using ByteBank.Funcionarios;

namespace ByteBank
{
	public class GerenciadorBonificacao
	{
		private double totalBonificacao;

		public void Registrar(Funcionario funcionario)
		{
			this.totalBonificacao += funcionario.GetBonificacao();
		}

		public double GetTotalBonificacao()
		{
			return totalBonificacao;
		}

	}
}
