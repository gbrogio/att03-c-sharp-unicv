namespace Exercicios;

public static class Ex58_IsEAs
{
    public static void Executar()
    {
        Shared.Animal a = new Shared.Gato(); if (a is Shared.Gato gato) Console.WriteLine(gato.EmitirSom()); var dog = a as Shared.Cachorro; Console.WriteLine(dog is null ? "Nao eh cachorro" : dog.EmitirSom());
    }
}
