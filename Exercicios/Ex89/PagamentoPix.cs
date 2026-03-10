using System;
using System.Collections.Generic;
using System.Text;

namespace Ex89
{
    public class PagamentoPix : Pagamento
    {
        public PagamentoPix(string tipo, double valor) : base(tipo, valor) { }
    }
}
