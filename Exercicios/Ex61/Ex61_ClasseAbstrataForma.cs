namespace Exercicios;

public static class Ex61_ClasseAbstrataForma
{
    public static void Executar()
    {
        Shared.Forma f = new Shared.Quadrado(2); Console.WriteLine(f.Descricao());
    }
}
