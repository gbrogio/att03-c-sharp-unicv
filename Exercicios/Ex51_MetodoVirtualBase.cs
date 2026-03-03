using System;

namespace Exercicios;

class VeiculoVirtualBase
{
	protected string modelo;

	public VeiculoVirtualBase(string modeloRecebido)
	{
		modelo = modeloRecebido;
	}

	public virtual void Descrever()
	{
		Console.WriteLine($"Veiculo base: {modelo}");
	}
}

public class Ex51_MetodoVirtualBase
{
	public static void Executar()
	{
		VeiculoVirtualBase veiculo = new VeiculoVirtualBase("Modelo Generico");
		veiculo.Descrever();
	}
}
