using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicios;
class Ex89_Payment
{
    public static void Executar()
    {
        SistemaPagamento sis = new SistemaPagamento();

        PagamentoPix pinkeys = new PagamentoPix("PIX", 300);

        PagamentoCartao card = new PagamentoCartao("Cartao", 2000);

        sis.ProcessarPagamento(pinkeys);
        Console.WriteLine();

        sis.ProcessarPagamento(card);

    }
}

