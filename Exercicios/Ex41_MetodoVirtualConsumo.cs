namespace Exercicios;

public partial class Veiculo
{
    public virtual void CalcularConsumo()
    {
        Console.WriteLine("Consumo de combustível não especificado para veículo genérico.");
    }
}

public class Ex41_MetodoVirtualConsumo
{
    public static void Executar() => Console.WriteLine("Método virtual CalcularConsumo adicionado à classe Veiculo.");
}