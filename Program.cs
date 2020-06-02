using System;

namespace Heran_aPOO
{
        class Program
    {
        static void Main(string[] args)
        {
            CPF cpf = new CPF();
            cpf.nome = "Gabriel";
            System.Console.WriteLine(cpf.Saudar() );
            
        }
    }
}
