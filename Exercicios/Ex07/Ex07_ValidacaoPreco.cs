namespace Exercicios;

public static class Ex07_ValidacaoPreco
{
    public static void Executar()
    {
        try { var prod = new Shared.Produto("Teclado", 0); Console.WriteLine(prod.Preco); } catch (Exception ex) { Console.WriteLine(ex.Message); }
    }
}
