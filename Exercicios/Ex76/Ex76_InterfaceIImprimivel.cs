namespace Exercicios;

public static class Ex76_InterfaceIImprimivel
{
    public static void Executar()
    {
        Shared.IImprimivel i = new Shared.Documento("Contrato"); i.Imprimir();
    }
}
