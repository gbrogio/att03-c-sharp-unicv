using System;
using System.Collections.Generic;
using System.Text;

namespace Ex84
{
    class Program
    {
        static void Main(string[] args)
        {
            Usuario user = new Usuario();
            Sistema sistem = new Sistema();

            sistem.Login(user);
        }
    }
}