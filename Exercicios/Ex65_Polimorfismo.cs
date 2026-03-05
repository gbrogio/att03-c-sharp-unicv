using System;
using System.Collections.Generic;

public abstract class Ex65_Polimorfismo
{
	public abstract double CalcularArea();
}

public class  Ex65_Circulo : Ex65_Polimorfismo
{
    public double Raio { get; set; }

    public Ex65_Circulo(double raio)
    {
        Raio = raio;
    }

    public override double CalcularArea()
    {
        return Math.PI * Raio * Raio;
    }
}

public class Ex65_Teste
{
    public void Executar()
    {
        List<Ex65_Circulo> formas = new List<Ex65_Circulo>
        {
            new Ex65_Circulo(2),
            new Ex65_Circulo(5)
        };
    }
}
