namespace Exercicios;

public static class Ex48_HerancaMultiplosNiveis
{
    public static void Executar()
    {
        var g = new Shared.GerenteHeranca("Dani", "444", 8000); Console.WriteLine(g.CalcularBonus());
    }
}
