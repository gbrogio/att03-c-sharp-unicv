using System;

namespace Exercicios;

abstract class FormaAbstrata
{
	public abstract double CalcularArea();
}

class Retangulo : FormaAbstrata
{
	public double largura;
	public double altura;

	public Retangulo(double larguraRecebida, double alturaRecebida)
	{
		largura = larguraRecebida;
		altura = alturaRecebida;
	}

	public override double CalcularArea()
	{
		return largura * altura;
	}
}

public class Ex62_MetodoAbstratoCalcularArea
{
	public static void Executar()
	{
		Retangulo retangulo = new Retangulo(4, 3);
		Console.WriteLine($"Metodo abstrato CalcularArea() usado em Retangulo. Area: {retangulo.CalcularArea()}");
	}
}
