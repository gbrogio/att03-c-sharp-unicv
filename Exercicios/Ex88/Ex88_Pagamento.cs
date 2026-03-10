using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicios;

class Ex88_Pagamento
{
    public static void Executar()
    {
        List<IPagamento> pagamentos = new List<IPagamento>();

        pagamentos.Add(new PagamentoPix("Pix", 2500));
        pagamentos.Add(new PagamentoCartao("Cartão", 2600));

        foreach (IPagamento p in pagamentos)
        {
            p.Exibir();
            Console.WriteLine();
        }

    }
}

