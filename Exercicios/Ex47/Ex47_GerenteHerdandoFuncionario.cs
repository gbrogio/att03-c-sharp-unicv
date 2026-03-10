namespace Exercicios;

public static class Ex47_GerenteHerdandoFuncionario
{
    public static void Executar()
    {
        var g = new Shared.GerenteHeranca("Caio", "333", 7000); Console.WriteLine(g.Descrever());
    }
}
