using System;
using System.Collections.Generic;
using System.Text;

namespace Ex86
{
    class Programa
    {
        static void Main(string[] args)
        {
            PagamentoPix pinkeys = new PagamentoPix("PIX", 3000);

            pinkeys.Exibir();
        }
    }
}
