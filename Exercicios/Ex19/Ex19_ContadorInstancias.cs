namespace Exercicios;

public static class Ex19_ContadorInstancias
{
    public static void Executar()
    {
        _ = new Shared.RegistroInstancias(); _ = new Shared.RegistroInstancias(); Console.WriteLine(Shared.RegistroInstancias.TotalInstancias);
    }
}
