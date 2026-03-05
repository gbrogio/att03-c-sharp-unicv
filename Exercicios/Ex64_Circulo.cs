using System;

public class Ex64_Circulo
{
    public double Raio { get; set; }

    public Ex64_Circulo(double raio)
    {
        Raio = raio;
    }

    public double CalcularArea()
    {
        return Math.PI * Raio * Raio;
    }
}
