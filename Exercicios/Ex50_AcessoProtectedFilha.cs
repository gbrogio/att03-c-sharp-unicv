using System;

namespace Exercicios;

class PessoaProtegidaFuncionario
{
	protected string nome;

	public PessoaProtegidaFuncionario(string nomeRecebido)
	{
		nome = nomeRecebido;
	}
}

class FuncionarioProtegido : PessoaProtegidaFuncionario
{
	private readonly string cargo;

	public FuncionarioProtegido(string nome, string cargo) : base(nome)
	{
		this.cargo = cargo;
	}

	public void ExibirDadosInternos()
	{
		Console.WriteLine($"Funcionario: {nome} | Cargo: {cargo}");
	}
}

public class Ex50_AcessoProtectedFilha
{
	public static void Executar()
	{
		FuncionarioProtegido funcionario = new("Joao", "Analista");
		funcionario.ExibirDadosInternos();
	}
}
