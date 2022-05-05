using System;
using System.Globalization;

namespace Projeto1
{

    class program
    {


        static void Main(string[] args)
        {

            Caixa x = new Caixa();


            Console.Write("Número da conta: ");
            x._number = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Titular da conta: ");
            x._name = Console.ReadLine();
            Console.Write("Haverá depósito inicial? ");
            x._deposit = bool.Parse(Console.ReadLine());



            if (x._deposit == false)
            { Console.WriteLine("Dados da conta: " + x); }

            else
            {
                Console.Write("Entre com o valor do depósito inicial: ");

                double depositar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                x.Somar(depositar);
                Console.WriteLine("Dados da conta: " + x);
                Console.Write("Deposite um valor: ");
                depositar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                x.Somar(depositar);
                Console.WriteLine("Dados atualizados: " + x);
                Console.Write("Entre com um valor para sacar: ");
                double tirar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                x.Sacar(tirar);
                Console.WriteLine("Dados atualizados: " + x);

            }


















        }



    }
}