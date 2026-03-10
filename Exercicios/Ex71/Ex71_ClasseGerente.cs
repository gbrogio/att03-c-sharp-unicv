namespace Exercicios;

public static class Ex71_ClasseGerente
{
    public static void Executar()
    {
        var g = new Shared.GerenteAbstrato("Leo", 7000); Console.WriteLine(g.CalcularSalario());
    }
}
