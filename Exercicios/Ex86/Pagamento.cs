using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicios;

class Ex86_Pagamento
{
    public string Tipo { get; set; }
    public double Valor { get; set; }

    public Ex86_Pagamento(string tipo, double valor)
    {
        Tipo = tipo;
        Valor = valor;
    }
    public void Exibir()
    {
        Console.WriteLine($"Pagamento Realizado! \nTipo: {Tipo} \nValor: {Valor}");
    }
}

