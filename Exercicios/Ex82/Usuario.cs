using System;
using System.Collections.Generic;
using System.Text;

namespace Ex82
{
    class Usuario : IPessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }

        public void MostrarDados()
        {
            Console.WriteLine($"Nome: {Nome} \nIdade: {Idade}");
        }
    }
}
