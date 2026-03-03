using System;

namespace Exercicios;

class ContaBanco
{
	public string titular;
	public decimal saldo;

	public ContaBanco(string titularRecebido, decimal saldoInicial)
	{
		titular = titularRecebido;
		saldo = saldoInicial;
	}
}

class ContaCorrenteBanco : ContaBanco
{
	public ContaCorrenteBanco(string titular, decimal saldoInicial) : base(titular, saldoInicial)
	{
	}
}

class ContaPoupancaBanco : ContaBanco
{
	public ContaPoupancaBanco(string titular, decimal saldoInicial) : base(titular, saldoInicial)
	{
	}
}

public class Ex54_ContaCorrenteContaPoupanca
{
	private static void ExibirSaldoConta(ContaBanco conta)
	{
		Console.WriteLine($"Titular: {conta.titular} | Saldo atual: {conta.saldo:C}");
	}

	public static void Executar()
	{
		ContaCorrenteBanco contaCorrente = new ContaCorrenteBanco("Carlos", 500m);
		ContaPoupancaBanco contaPoupanca = new ContaPoupancaBanco("Bianca", 500m);

		ExibirSaldoConta(contaCorrente);
		ExibirSaldoConta(contaPoupanca);
	}
}
