namespace Exercicios;

public partial class Moto : Veiculo
{
    public Moto(string marca) : base(marca) { }
}

public class Ex39_ClasseMoto
{
    public static void Executar() => Console.WriteLine("Classe Moto criada herdando de Veiculo.");
}