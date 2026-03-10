using System;
using System.Collections.Generic;
using System.Text;

namespace Ex90
{
    public class PagamentoPix : Pagamento
    {
        public PagamentoPix(double valor) : base("PIX", valor) { }

        public override void Processar()
        {
            Console.WriteLine($"Pix de {Valor} realizado!");

        }
    }
}
