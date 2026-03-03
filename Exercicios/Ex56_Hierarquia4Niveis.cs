using System;

namespace Exercicios;

class SerVivoHierarquia
{
	public virtual void Respirar()
	{
		Console.WriteLine("Ser vivo respirando.");
	}
}

class AnimalHierarquia : SerVivoHierarquia
{
	public virtual void Mover()
	{
		Console.WriteLine("Animal se movendo.");
	}
}

class MamiferoHierarquia : AnimalHierarquia
{
	public void Amamentar()
	{
		Console.WriteLine("Mamifero amamentando.");
	}
}

class CaoHierarquia : MamiferoHierarquia
{
	public void Latir()
	{
		Console.WriteLine("Cao latindo.");
	}
}

public class Ex56_Hierarquia4Niveis
{
	public static void Executar()
	{
		CaoHierarquia cao = new CaoHierarquia();
		cao.Respirar();
		cao.Mover();
		cao.Amamentar();
		cao.Latir();
	}
}
