using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Ex90
{
    public class PagamentoCartao : Pagamento
    {
        public PagamentoCartao(double valor) : base("Cartão", valor) { }
        public override void Processar()
        {
            Console.WriteLine($"Processando pagamento no cartão de R${Valor}");
        }
        
    }
}
