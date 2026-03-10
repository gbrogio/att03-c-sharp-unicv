using System;
using System.Collections.Generic;
using System.Text;
using Ex85;

namespace EX85
{
    class Program
    {
        static void Main(string[] args)
        {
            Pagamento pagamento = new Pagamento();

            pagamento.valor = 17.50;
            pagamento.tipo = "Pinkeys";

            pagamento.Exibir();
        }
    }

}