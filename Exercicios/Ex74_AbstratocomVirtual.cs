using System;

public abstract class Ex74_AbstratocomVirtual
{
    public abstract double CalcularSalario()

    public virtual string Cargo()
    {
        return "Funcionario"
    }
}

public class Ex74_AbstratocomVirtual_Gerente : Ex74_AbstratocomVirtual
{
    public override double CalcularSalario()
    {
        return 5000.00;
    }
    public override string Cargo()
    {
        return "Gerente";
    }
}