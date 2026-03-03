using System;

namespace Exercicios;

class ContaParametroBase
{
	public string titular;
	public decimal saldo;

	public ContaParametroBase(string titularRecebido, decimal saldoInicial)
	{
		titular = titularRecebido;
		saldo = saldoInicial;
	}
}

class ContaCorrenteParametroBase : ContaParametroBase
{
	public ContaCorrenteParametroBase(string titular, decimal saldoInicial) : base(titular, saldoInicial)
	{
	}
}

public class Ex59_MetodoRecebeClasseBase
{
	private static void ExibirSaldoConta(ContaParametroBase conta)
	{
		Console.WriteLine($"Titular: {conta.titular} | Saldo atual: {conta.saldo:C}");
	}

	public static void Executar()
	{
		ContaParametroBase conta = new ContaCorrenteParametroBase("Helena", 900m);
		ExibirSaldoConta(conta);
	}
}
