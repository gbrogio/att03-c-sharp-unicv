namespace Exercicios;

public static class Ex33_MetodoVirtualEmitirSom
{
    public static void Executar()
    {
        Shared.Animal a = new Shared.Cachorro(); Console.WriteLine(a.EmitirSom());
    }
}
