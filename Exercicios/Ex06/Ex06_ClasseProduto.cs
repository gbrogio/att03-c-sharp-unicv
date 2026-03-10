namespace Exercicios;

public static class Ex06_ClasseProduto
{
    public static void Executar()
    {
        var prod = new Shared.Produto("Mouse", 100); Console.WriteLine($"{prod.Nome}: {prod.Preco:F2}");
    }
}
