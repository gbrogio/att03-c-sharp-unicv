using System;
using System.Collections.Generic;
using System.Text;

namespace Ex88
{
    class PagamentoCartao : Pagamento
    {
        public PagamentoCartao(string tipo, double valor) : base(tipo, valor) { }
    }
}
