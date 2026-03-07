using System;

public class Ex24_PedidoIdAutomatico {
    private static int contadorGlobal = 1000;
    public int PedidoId { get; }
    public string Cliente { get; set; }

    public Ex24_PedidoIdAutomatico(string cliente) {
        this.PedidoId = ++contadorGlobal;
        this.Cliente = cliente;
    }

    public void ImprimirRecibo() {
        Console.WriteLine($"Pedido #{PedidoId} - Cliente: {Cliente}");
    }
}