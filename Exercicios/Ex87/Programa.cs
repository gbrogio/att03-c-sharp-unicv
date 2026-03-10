using System;
using System.Collections.Generic;
using System.Text;

namespace Ex87
{
    class Programa
    {
        static void Main(string[] args)
        {
            PagamentoPix pix = new PagamentoPix("PIX", 3000);
            PagamentoCartao cartao = new PagamentoCartao("Cartão", 250);

            pix.Exibir();
            Console.WriteLine();
            cartao.Exibir();
        }
    }
}
