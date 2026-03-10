using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicios;

class Usuario : IPessoa
{
    public string Nome { get; set; }
    public int Idade { get; set; }

    public void MostrarDados()
    {
        Console.WriteLine($"Nome: {Nome} \nIdade: {Idade}");
    }
}

