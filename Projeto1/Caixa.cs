using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Projeto1
{
    internal class Caixa
    {
        public string _name;
        public double _number;
        public char _deposit;
        public double _money;
        public double _balance;
       

        public Caixa()
        {

        }

        public Caixa(string nome, double numero, char deposito, double dinheiro, double saldo)
        {
            _name = nome; _number = numero; _deposit = deposito; _money = dinheiro; _balance = saldo;
        }

        public void Somar(double dinheiro)
        {
            _money += dinheiro;
        }

        public void Sacar(double dinheiro)
        {
            _money -= dinheiro + 5.0;            
        }

        public double SaldoFinal()
        {
            return _money;
        }


        public override string ToString()
        {
            return "Conta: " + _number + "," + "Titular: " + _name + "," + "Saldo: " + SaldoFinal().
            ToString("F2", CultureInfo.InvariantCulture);
        }












    }
}

