using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicios;
class Ex87_Pagamento
{
    public static void Executar()
    {
        PagamentoPix pix = new PagamentoPix("PIX", 3000);
        PagamentoCartao cartao = new PagamentoCartao("Cartão", 250);

        pix.Exibir();
        Console.WriteLine();
        cartao.Exibir();
    }
}

