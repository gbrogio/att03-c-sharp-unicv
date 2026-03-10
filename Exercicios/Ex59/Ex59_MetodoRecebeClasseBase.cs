namespace Exercicios;

public static class Ex59_MetodoRecebeClasseBase
{
    public static void Executar()
    {
        void ExibirSom(Shared.Animal a) => Console.WriteLine(a.EmitirSom()); ExibirSom(new Shared.Cachorro());
    }
}
