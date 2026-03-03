using System;

namespace Exercicios;

class PessoaProtegidaSimples
{
	protected string nome;

	public PessoaProtegidaSimples(string nomeRecebido)
	{
		nome = nomeRecebido;
	}

	public string Apresentar()
	{
		return $"Pessoa: {nome}";
	}
}

public class Ex49_ProtectedAtributo
{
	public static void Executar()
	{
		PessoaProtegidaSimples pessoa = new PessoaProtegidaSimples("Maria");
		Console.WriteLine(pessoa.Apresentar());
	}
}
