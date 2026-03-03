using System;

namespace Exercicios;

class ContaPolimorfica
{
	public string titular;
	public decimal saldo;

	public ContaPolimorfica(string titularRecebido, decimal saldoInicial)
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

class ContaCorrentePolimorfica : ContaPolimorfica
{
	private const decimal TaxaSaque = 2.50m;

	public ContaCorrentePolimorfica(string titular, decimal saldoInicial) : base(titular, saldoInicial)
	{
	}

	public override bool Sacar(decimal valor)
	{
		decimal valorTotal = valor + TaxaSaque;
		Console.WriteLine($"Conta corrente aplica taxa de {TaxaSaque:C}.");
		return base.Sacar(valorTotal);
	}
}

class ContaPoupancaPolimorfica : ContaPolimorfica
{
	public ContaPoupancaPolimorfica(string titular, decimal saldoInicial) : base(titular, saldoInicial)
	{
	}

	public override bool Sacar(decimal valor)
	{
		Console.WriteLine("Conta poupanca sem taxa de saque.");
		return base.Sacar(valor);
	}
}

public class Ex60_PolimorfismoReferenciaBase
{
	public static void Executar()
	{
		ContaPolimorfica conta1 = new ContaCorrentePolimorfica("Igor", 250m);
		ContaPolimorfica conta2 = new ContaPoupancaPolimorfica("Julia", 250m);

		conta1.Sacar(100m);
		conta2.Sacar(100m);
	}
}
