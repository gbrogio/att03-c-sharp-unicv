using System;
using System.Collections.Generic;
using System.Text;

namespace Ex88
{
    class Pagamento : IPagamento
    {
        public string Tipo { get; set; }
        public double Valor { get; set; }

        public Pagamento(string tipo, double valor)
        {
            Tipo = tipo;
            Valor = valor;
        }
        public void Exibir()
        {
            Console.WriteLine($"Pagamento realizado! \nTipo: {Tipo} \nValor: {Valor}");
        }
    }
}
