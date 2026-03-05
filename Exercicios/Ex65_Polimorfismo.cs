using System;

public abstract class Ex65_Polimorfismo
{
	public abstract double CalcularArea();
}

public class  Ex65_Circulo : Ex65_Forma
{
    `public double Raio { get; set; }

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
        List<Ex65_Polimorfismo> formas = new List<Ex65_Polimorfismo>
        {
            new Ex65_Circulo(2),
            new Ex65_Circulo(5)
        }
    }
}
