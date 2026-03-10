namespace Exercicios;

public static class Ex52_SobrescritaParcialBase
{
    public static void Executar()
    {
        var g = new Shared.GerenteHeranca("Heitor", "888", 9000); Console.WriteLine(g.CalcularBonus());
    }
}
