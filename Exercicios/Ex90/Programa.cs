using System;
using System.Collections.Generic;
using System.Text;

namespace Ex90
{
    public class Programa
    {
        static void Main(string[] args)
        {
            List<IPagamento> pagamentos = new List<IPagamento>();

            pagamentos.Add(new PagamentoPix(250));
            pagamentos.Add(new PagamentoCartao(700));

            foreach (IPagamento pagamento in pagamentos) 
            {
                pagamento.Processar();
            }

        }
    }
}
