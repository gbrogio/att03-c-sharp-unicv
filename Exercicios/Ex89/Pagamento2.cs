using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicios;
public class Pagamento2 : IPagamento
{
    public string Tipo { get; set; }
    public double Valor { get; set; }

    public Pagamento2(string tipo, double valor)
    {
        Tipo = tipo;
        Valor = valor;
    }

    public void Exibir()
    {
        Console.WriteLine($"Pagamento Realizado!\nTipo: {Tipo}\nValor: {Valor}");
    }
}

