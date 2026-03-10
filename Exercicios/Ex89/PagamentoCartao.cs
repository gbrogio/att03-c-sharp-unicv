using System;
using System.Collections.Generic;
using System.Text;

namespace Ex89
{
    public class PagamentoCartao :Pagamento
    {
        public PagamentoCartao (string tipo, double valor) : base (tipo, valor) { }

    } 
}
