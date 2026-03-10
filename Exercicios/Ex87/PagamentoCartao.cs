using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicios;
    class PagamentoCartao : Pagamento
    {
        public PagamentoCartao(string tipo, double valor) : base(tipo, valor) { }
    }

