using System;
using System.Collections.Generic;
using System.Text;

namespace Ex87
{
    class PagamentoCartao : Pagamento
    {
        public PagamentoCartao(string tipo, double valor) : base(tipo, valor) { }
    }
}
