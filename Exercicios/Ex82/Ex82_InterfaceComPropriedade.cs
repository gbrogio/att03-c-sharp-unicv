namespace Exercicios;

public static class Ex82_InterfaceComPropriedade
{
    public static void Executar()
    {
        var status = new StatusEx82 { Ativo = true }; Console.WriteLine(status.Ativo);
    }
}


public class StatusEx82 : IStatusOperacao
{
    public bool Ativo { get; set; }
}
