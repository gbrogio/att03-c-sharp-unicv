using System;

namespace Exercicios;

class ContaTipo
{
	public string titular;

	public ContaTipo(string titularRecebido)
	{
		titular = titularRecebido;
	}
}

class ContaCorrenteTipo : ContaTipo
{
	public ContaCorrenteTipo(string titular) : base(titular)
	{
	}
}

class ContaPoupancaTipo : ContaTipo
{
	public ContaPoupancaTipo(string titular) : base(titular)
	{
	}
}

public class Ex58_IsEAs
{
	public static void Executar()
	{
		ContaTipo conta = new ContaPoupancaTipo("Gabi");

		if (conta is ContaPoupancaTipo)
		{
			Console.WriteLine("Operador is: conta eh uma ContaPoupanca.");
		}

		ContaCorrenteTipo? contaCorrente = conta as ContaCorrenteTipo;
		Console.WriteLine(contaCorrente is null
			? "Operador as: conversao para ContaCorrente retornou null."
			: "Operador as: conversao para ContaCorrente funcionou.");
	}
}
