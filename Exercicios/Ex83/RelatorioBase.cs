namespace Exercicios;

public abstract class RelatorioBase : IRelatorio
{
    public abstract string Titulo { get; }
    public abstract void Gerar();

    public virtual string Cabecalho() => $"Relatorio: {Titulo}";
}
