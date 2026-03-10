namespace Exercicios.Shared;

public class Produto
{
    public string Nome { get; set; }
    private double _preco;

    public double Preco
    {
        get => _preco;
        set
        {
            if (value <= 0)
            {
                throw new ArgumentException("Preco deve ser maior que zero.");
            }

            _preco = value;
        }
    }

    public Produto(string nome, double preco)
    {
        Nome = nome;
        Preco = preco;
    }

    public void AplicarDesconto(double percentual)
    {
        if (percentual < 0 || percentual > 100)
        {
            throw new ArgumentException("Percentual invalido.");
        }

        Preco -= Preco * (percentual / 100.0);
    }
}
