﻿using ByteBank.Funcionarios;

namespace ByteBank
{
	public class ParceiroComercial : IAutenticavel
	{
		public string Senha { get; set; }
		public bool Autenticar(string senha)
		{
			return this.Senha == senha;
		}
	}
}
