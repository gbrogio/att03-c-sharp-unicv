namespace Exercicios;

public partial class Carro
{
    public sealed override void CalcularConsumo()
    {
        Console.WriteLine("Consumo de Carro selado: 12 km/l (não pode ser alterado por subclasses).");
    }
}

public class Ex44_UseSealedOverride
{
    public static void Executar() => Console.WriteLine("Método CalcularConsumo selado na classe Carro.");
}