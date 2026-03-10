using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicios;

class PagamentoPix : Pagamento
{
    public PagamentoPix(string tipo, double valor) : base(tipo, valor) { }
}

