using System;

public interface Ex75_InterfaceAbstrata
{
    void Gerar();
}

public abstract class Ex75_InterfaceAbstrataGerar : Ex75_InterfaceAbstrata
{
    public abstract void Gerar();
}

public class Ex75_InterfaceAbstrataGerarRelatorio : Ex75_InterfaceAbstrataGerar
{
    public override void Gerar()
    {
        Console.WriteLine("Gerando relatório...");
    }
}

