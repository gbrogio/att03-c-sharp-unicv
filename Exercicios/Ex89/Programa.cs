using System;
using System.Collections.Generic;
using System.Text;

namespace Ex89
{
    class Programa
    {
        static void Main()
        {
            SistemaPagamento sis = new SistemaPagamento();

            PagamentoPix pinkeys = new PagamentoPix("PIX", 300);

            PagamentoCartao card = new PagamentoCartao("Cartao", 2000);

            sis.ProcessarPagamento(pinkeys);
            Console.WriteLine();

            sis.ProcessarPagamento(card);

        }
    }
}
