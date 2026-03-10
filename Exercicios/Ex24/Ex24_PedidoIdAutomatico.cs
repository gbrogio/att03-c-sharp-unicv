namespace Exercicios;

public static class Ex24_PedidoIdAutomatico
{
    public static void Executar()
    {
        var p1 = new Pedido(); var p2 = new Pedido(); Console.WriteLine($"{p1.Id} - {p2.Id}");
    }
}
