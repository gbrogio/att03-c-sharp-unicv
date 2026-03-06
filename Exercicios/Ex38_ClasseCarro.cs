namespace Exercicios;

public partial class Carro : Veiculo
{
    public Carro(string marca) : base(marca) { }
}

public class Ex38_ClasseCarro
{
    public static void Executar() => Console.WriteLine("Classe Carro criada herdando de Veiculo.");
}