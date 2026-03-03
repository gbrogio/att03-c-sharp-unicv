namespace Exercicios;
using System;

public enum ModoAmamentacao
{
	GlandulasMamarias,
	SecrecaoPorPoros // POR QUE ONITORRINCO? POR QUÊ?
}

public class Animal(string nomePopular)
{
	public string nomePopular = nomePopular;

  public void Comer()
	{
		Console.WriteLine($"{nomePopular} está comendo.");
	}
}

public class Mamifero(string nomePopular, ModoAmamentacao modoAmamentacao) : Animal(nomePopular)
{
	public ModoAmamentacao modoAmamentacao = modoAmamentacao;

  public void Amamentar()
	{
		Console.WriteLine($"{nomePopular} está amamentando. Através de {modoAmamentacao}.");
	}
}

public class Cachorro(string nome) : Mamifero("Cachorro", ModoAmamentacao.GlandulasMamarias)
{
	public string nome = nome;

  public void Latir()
	{
		Console.WriteLine($"{nome} está latindo.");
	}
}

public class Onitorrinco(string nome) : Mamifero("Onitorrinco", ModoAmamentacao.SecrecaoPorPoros)
{
	public string nome = nome;

  public void BotarOvos(int quantidade)
	{
		Console.WriteLine($"{nome} está botando {quantidade} ovo(s).");
	}
}

public class Ex48_HerancaMultiplosNiveis
{
	public static void Executar()
	{
		Cachorro cachorro = new Cachorro("Rex");

		cachorro.Comer();
		cachorro.Amamentar();
		cachorro.Latir();

		Onitorrinco onitorrinco = new Onitorrinco("Perry");

		onitorrinco.Comer();
		onitorrinco.Amamentar();
		onitorrinco.BotarOvos(2);
	}
}