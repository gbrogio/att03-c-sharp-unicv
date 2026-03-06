namespace Exercicios;

public partial class Cachorro
{
    public override void EmitirSom() => Console.WriteLine("O Cachorro late: Au Au!");
}

public class Ex34_SobrescrevaEmCachorro
{
    public static void Executar()
    {
        Cachorro dog = new Cachorro();
        dog.EmitirSom();
    }
}