using System;

public class  Ex71_Gerente : Ex69_SalarioAbstrato
{
    public double SalarioBase { get; set; }

    public Ex71_Gerente(double salarioBase)
    {
        SalarioBase = salarioBase;
    }

    public override double CalcularSalario()
    {
        return SalarioBase * 1.25;
    }
}
