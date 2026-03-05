using System;

public class Ex67_ClasseConcreta : Ex66_ClasseAbstrata
{
    public double Raio { get; set; }

    public Ex67_ClasseConcreta(double raio)
    {
        Raio = raio;
    }

    public override double Area => Math.PI * Raio * Raio;
}
