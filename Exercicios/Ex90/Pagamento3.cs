using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicios;
public class Pagamento3 :IPagamento3
{
    public string Tipo { get; set; }
    public double Valor { get; set; }

    public Pagamento3 (string tipo, double valor)
    {
        Tipo = tipo;
        Valor = valor;
    }

    public virtual void Processar()
    {
        Console.WriteLine($"Pagamento de {Valor} via {Tipo} realizado!");
    }
}

