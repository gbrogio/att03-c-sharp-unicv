namespace Exercicios;

public class Pedido
{
    private static int _proximoId = 1;
    public int Id { get; }

    public Pedido()
    {
        Id = _proximoId++;
    }
}
