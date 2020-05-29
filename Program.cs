using System;

namespace HerancaPoo
{
    class Program
    {
        static void Main(string[] args)
        {
            CPF cpf = new CPF();
            cpf.nome = "Makoto";
            Console.WriteLine( cpf.Saudar() );

            cpf.cpf = "012.345.678-90";
            Console.WriteLine( cpf.Validarcpf() );

        }
    }
}
