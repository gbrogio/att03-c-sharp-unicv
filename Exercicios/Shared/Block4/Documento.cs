namespace Exercicios.Shared;

public class Documento : IImprimivel
{
    public string Conteudo { get; }

    public Documento(string conteudo)
    {
        Conteudo = conteudo;
    }

    public void Imprimir()
    {
        Console.WriteLine($"Documento: {Conteudo}");
    }
}
