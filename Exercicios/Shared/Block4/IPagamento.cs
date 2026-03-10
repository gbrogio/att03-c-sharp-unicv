namespace Exercicios.Shared;

public interface IPagamento
{
    string Descricao { get; }
    bool Processar(double valor);
}
