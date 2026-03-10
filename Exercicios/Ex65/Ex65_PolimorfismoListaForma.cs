namespace Exercicios;

public static class Ex65_PolimorfismoListaForma
{
    public static void Executar()
    {
        var formas = new List<Shared.Forma> { new Shared.Quadrado(2), new Shared.Circulo(2) }; foreach (var f in formas) Console.WriteLine(f.CalcularArea().ToString("F2"));
    }
}
