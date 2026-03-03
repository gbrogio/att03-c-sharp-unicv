using System;

namespace Exercicios;

class ContaCasting
{
	public string titular;

	public ContaCasting(string titularRecebido)
	{
		titular = titularRecebido;
	}
}

class ContaCorrenteCasting : ContaCasting
{
	public ContaCorrenteCasting(string titular) : base(titular)
	{
	}
}

public class Ex57_CastingEntreTipos
{
	public static void Executar()
	{
		ContaCasting contaBase = new ContaCorrenteCasting("Fabio");
		ContaCorrenteCasting contaCorrente = (ContaCorrenteCasting)contaBase;

		Console.WriteLine($"Casting explicito realizado para ContaCorrente de {contaCorrente.titular}.");
	}
}
