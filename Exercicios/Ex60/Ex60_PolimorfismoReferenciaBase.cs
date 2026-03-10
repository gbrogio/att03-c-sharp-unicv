namespace Exercicios;

public static class Ex60_PolimorfismoReferenciaBase
{
    public static void Executar()
    {
        Shared.Animal a = new Shared.Gato(); Console.WriteLine(a.EmitirSom());
    }
}
