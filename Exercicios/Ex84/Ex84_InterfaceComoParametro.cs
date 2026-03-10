namespace Exercicios;

public static class Ex84_InterfaceComoParametro
{
    public static void Executar()
    {
        void ImprimirItem(Shared.IImprimivel item) => item.Imprimir(); ImprimirItem(new Shared.Documento("Relatorio"));
    }
}
