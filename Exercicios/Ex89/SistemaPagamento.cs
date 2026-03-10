using System;
using System.Collections.Generic;
using System.Text;

namespace Ex89
{
    public class SistemaPagamento
    { 
        public void ProcessarPagamento(IPagamento pagamento)
        {
            Console.WriteLine("Processando pagamento...");
            pagamento.Exibir();
        }
        
    }
}
