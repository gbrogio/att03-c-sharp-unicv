using System;

public class Ex70_Desenvolvedor : Ex69_SalarioAbstrato
{
    public double SalarioBase { get; set; }

    public Ex70_Desenvolvedor(double salarioBase){
        SalarioBase = salarioBase;
    }

    public override double CalcularSalario() //Ex69
    {
        return SalarioBase * 1.1;
    }
}