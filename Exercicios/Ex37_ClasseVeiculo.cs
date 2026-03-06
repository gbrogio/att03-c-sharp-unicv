namespace Exercicios;

public partial class Veiculo
{
    public string Marca { get; set; }
    public Veiculo(string marca) { Marca = marca; }
}

public class Ex37_ClasseVeiculo
{
    public static void Executar() => Console.WriteLine("Classe Veiculo com construtor criada.");
}