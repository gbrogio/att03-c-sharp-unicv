namespace Exercicios;

public class Gato : Animal
{
    public override void EmitirSom() => Console.WriteLine("O Gato mia: Miau!");
}

public class Ex35_ClasseGato
{
    public static void Executar() => Console.WriteLine("Classe Gato criada e configurada.");
}