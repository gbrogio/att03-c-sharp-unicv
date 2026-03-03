using System;

namespace Exercicios;

abstract class FormaQuadrado
{
	public abstract double CalcularArea();
}

class Quadrado : FormaQuadrado
{
	public double lado;

	public Quadrado(double ladoRecebido)
	{
		lado = ladoRecebido;
	}

	public override double CalcularArea()
	{
		return lado * lado;
	}
}

public class Ex63_ClasseQuadrado
{
	public static void Executar()
	{
		Quadrado quadrado = new Quadrado(5);
		Console.WriteLine($"Area do quadrado de lado {quadrado.lado}: {quadrado.CalcularArea()}");
	}
}
