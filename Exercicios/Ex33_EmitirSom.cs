namespace Exercicios;

public partial class Animal
{
    public virtual void EmitirSom() => Console.WriteLine("Animal emitindo som genérico...");
}

public class Ex33_AdicioneMetodoEmitirSom
{
    public static void Executar() => Console.WriteLine("Método virtual EmitirSom adicionado à base.");
}