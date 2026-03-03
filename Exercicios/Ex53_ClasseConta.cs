using System;

namespace Exercicios;

class ContaBasica
{
	public string titular;
	public decimal saldo;

	public ContaBasica(string titularRecebido, decimal saldoInicial)
	{
		titular = titularRecebido;
		saldo = saldoInicial;
	}
}

public class Ex53_ClasseConta
{
	private static void ExibirSaldoConta(ContaBasica conta)
	{
		Console.WriteLine($"Titular: {conta.titular} | Saldo atual: {conta.saldo:C}");
	}

	public static void Executar()
	{
		ContaBasica conta = new ContaBasica("Ana", 1000m);
		ExibirSaldoConta(conta);
	}
}
