using System;

namespace Exercicios;

class ContaSaque
{
	public string titular;
	public decimal saldo;

	public ContaSaque(string titularRecebido, decimal saldoInicial)
	{
		titular = titularRecebido;
		saldo = saldoInicial;
	}

	public virtual bool Sacar(decimal valor)
	{
		if (valor <= 0 || saldo < valor)
		{
			return false;
		}

		saldo -= valor;
		Console.WriteLine($"Saque de {valor:C} realizado na conta de {titular}.");
		return true;
	}
}

class ContaCorrenteSaque : ContaSaque
{
	private const decimal TaxaSaque = 2.50m;

	public ContaCorrenteSaque(string titular, decimal saldoInicial) : base(titular, saldoInicial)
	{
	}

	public override bool Sacar(decimal valor)
	{
		decimal valorTotal = valor + TaxaSaque;
		Console.WriteLine($"Conta corrente aplica taxa de {TaxaSaque:C}.");
		return base.Sacar(valorTotal);
	}
}

class ContaPoupancaSaque : ContaSaque
{
	public ContaPoupancaSaque(string titular, decimal saldoInicial) : base(titular, saldoInicial)
	{
	}

	public override bool Sacar(decimal valor)
	{
		Console.WriteLine("Conta poupanca sem taxa de saque.");
		return base.Sacar(valor);
	}
}

public class Ex55_SobrescreverSacar
{
	private static void ExibirSaldoConta(ContaSaque conta)
	{
		Console.WriteLine($"Titular: {conta.titular} | Saldo atual: {conta.saldo:C}");
	}

	public static void Executar()
	{
		ContaCorrenteSaque contaCorrente = new ContaCorrenteSaque("Davi", 300m);
		ContaPoupancaSaque contaPoupanca = new ContaPoupancaSaque("Elisa", 300m);

		contaCorrente.Sacar(100m);
		contaPoupanca.Sacar(100m);

		ExibirSaldoConta(contaCorrente);
		ExibirSaldoConta(contaPoupanca);
	}
}
