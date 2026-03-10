using System;
using System.Collections.Generic;
using System.Text;

namespace Ex88
{
    class Programa
    {
        static void Main(string[] args)
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
}
