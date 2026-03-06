namespace Exercicios;

public class Ex40_UsoBaseConstrutor
{
    public static void Executar()
    {
        Carro meuCarro = new Carro("VW Fusca 77");
        Console.WriteLine($"Instanciado via base(): {meuCarro.Marca}");
    }
}