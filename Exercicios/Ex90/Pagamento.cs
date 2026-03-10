using System;
using System.Collections.Generic;
using System.Text;

namespace Ex90
{
    public class Pagamento :IPagamento
    {
        public string Tipo { get; set; }
        public double Valor { get; set; }

        public Pagamento (string tipo, double valor)
        {
            Tipo = tipo;
            Valor = valor;
        }

        public virtual void Processar()
        {
            Console.WriteLine($"Pagamento de {Valor} via {Tipo} realizado!");
        }
    }
}
