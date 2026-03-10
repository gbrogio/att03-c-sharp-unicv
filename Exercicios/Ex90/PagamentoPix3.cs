using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicios;
public class PagamentoPix3 : Pagamento3
{
    public PagamentoPix3(double valor) : base("PIX", valor) { }

    public override void Processar()
    {
        Console.WriteLine($"Pix de {Valor} realizado!");

    }
}