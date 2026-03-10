using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicios;
public class Ex90_Pagamento
{
    static void Main(string[] args)
    {
        List<IPagamento3> pagamentos = new List<IPagamento3>();

        pagamentos.Add(new PagamentoPix3(250));
        pagamentos.Add(new PagamentoCartao3(700));

        foreach (IPagamento pagamento in pagamentos) 
        {
            pagamento.Processar();
        }

    }
}

