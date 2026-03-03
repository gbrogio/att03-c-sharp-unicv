using System;

namespace Exercicios;

class VeiculoVirtualDetalhado
{
	protected string modelo;

	public VeiculoVirtualDetalhado(string modeloRecebido)
	{
		modelo = modeloRecebido;
	}

	public virtual void Descrever()
	{
		Console.WriteLine($"Veiculo base: {modelo}");
	}
}

class CarroOverrideParcial : VeiculoVirtualDetalhado
{
	private readonly int portas;

	public CarroOverrideParcial(string modelo, int portas) : base(modelo)
	{
		this.portas = portas;
	}

	public override void Descrever()
	{
		base.Descrever();
		Console.WriteLine($"Detalhe do carro: {portas} portas.");
	}
}

public class Ex52_SobrescritaParcialComBase
{
	public static void Executar()
	{
		CarroOverrideParcial carro = new CarroOverrideParcial("Sedan", 4);
		carro.Descrever();
	}
}
