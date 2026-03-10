using System;
using System.Collections.Generic;
using System.Text;

namespace Ex85
{
    class Pagamento
    {
        public string tipo { get; set; }
        public double valor { get; set; }

        public void Exibir()
        {
            Console.WriteLine($"Tipo: {tipo} \nValor: {valor}");
        }
    }
}