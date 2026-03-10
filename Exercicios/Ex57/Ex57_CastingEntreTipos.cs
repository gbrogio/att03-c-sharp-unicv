namespace Exercicios;

public static class Ex57_CastingEntreTipos
{
    public static void Executar()
    {
        Shared.Animal a = new Shared.Cachorro(); var c = (Shared.Cachorro)a; Console.WriteLine(c.EmitirSom());
    }
}
